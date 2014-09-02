using System;
using System.Collections.Generic;
using System.Threading;
using Top.Api.Stream.Connect;
using Top.Api.Stream.Message;
using Top.Api.Util;
using System.Diagnostics;

namespace Top.Api.Stream
{
    public class TopCometStreamImpl : ITopCometStream
    {
        private ITopLogger logger = new DefaultTopLogger();
        private IConnectionLifeCycleListener connectionListener;
        private ITopCometMessageListener cometMessageListener;
        private Configuration conf;
        private StreamMsgConsumeFactory msgConsumeFactory = null;

        /**
         * 停掉
         */
        public bool bstop = false;
        public bool allStop = false;

        private List<Thread> controlThreads = new List<Thread>();

        /*
         * 各种状态
         */
        public string serverRespCode = StreamConstants.CLIENT_FIRST_CONNECT;
        public IStreamImplementation currentStreamImpl;
        private bool isReconnect = false;//是否客户端发起重连
        private long lastStartConsumeThread = System.DateTime.Now.Ticks;
        private object objLock = new object();

        private bool closed = false;
        private int startConsumeThreadTimes = 0;

        public TopCometStreamImpl(Configuration conf)
        {
            this.conf = conf;
        }

        public void SetConnectionListener(IConnectionLifeCycleListener connectionLifeCycleListener)
        {
            this.connectionListener = connectionLifeCycleListener;
        }

        public void SetMessageListener(ITopCometMessageListener cometMessageListener)
        {
            this.cometMessageListener = cometMessageListener;
        }

        public void Start()
        {
            List<TopCometStreamRequest> cometRequests = conf.GetConnectReqParam();

            msgConsumeFactory = new StreamMsgConsumeFactory(conf.GetMinThreads(), conf.GetMaxThreads(), conf.GetQueueSize());

            for (int i = 0; i < cometRequests.Count; i++)
            {
                try
                {
                    TopCometStreamRequest cometRequest = cometRequests[i];
                    if (cometRequest.GetConnectListener() == null)
                    {
                        cometRequest.SetConnectListener(connectionListener);
                    }
                    if (cometRequest.GetMsgListener() == null)
                    {
                        cometRequest.SetMsgListener(cometMessageListener);
                    }
                    Thread controlThread = new Thread(delegate()
                    {
                        ControlThread(msgConsumeFactory, ref bstop, conf, cometRequest);
                    });
                    controlThread.Name = "stream-control-thread-connectid-" + cometRequest.GetConnectId();
                    controlThread.Start();
                    controlThreads.Add(controlThread);
                }
                catch (Exception e)
                {
                    continue;
                }
            }

        }

        void ControlThread(StreamMsgConsumeFactory msgConsumeFactory, ref bool bstop, Configuration conf, TopCometStreamRequest cometReq)
        {
            long lastSleepTime = 0;
            while (!bstop)
            {
                if (allStop)
                {
                    break;
                }

                try
                {
                    if (StreamConstants.SERVER_DEPLOY.Equals(serverRespCode))
                    {   // 服务端在发布
                        logger.Info("Server is upgrade sleep " + conf.GetSleepTimeOfServerInUpgrade() + " seconds");
                        Thread.Sleep(conf.GetSleepTimeOfServerInUpgrade() * 1000);
                        StartConsumeThread(cometReq);
                    }
                    else if (/*客户端第一次发起连接请求*/
                          StreamConstants.CLIENT_FIRST_CONNECT.Equals(serverRespCode) ||
                        /*服务端主动断开了所有的连接*/
                          StreamConstants.SERVER_REHASH.Equals(serverRespCode) ||
                        /*连接到达最大时间*/
                          StreamConstants.CONNECT_REACH_MAX_TIME.Equals(serverRespCode) ||
                        /*在一些异常情况下需要重连*/
                          StreamConstants.RECONNECT.Equals(serverRespCode))
                    {
                        StartConsumeThread(cometReq);
                    }
                    else if (/*客户端自己把自己踢开*/
                          StreamConstants.CLIENT_KICKOFF.Equals(serverRespCode) ||
                        /*服务端把客户端踢开*/
                          StreamConstants.SERVER_KICKOFF.Equals(serverRespCode))
                    {
                        if ((StreamConstants.CLIENT_KICKOFF.Equals(serverRespCode) && !isReconnect) ||
                           StreamConstants.SERVER_KICKOFF.Equals(serverRespCode))
                        {

                            break;// 终止掉当前线程
                        }
                    }
                    else
                    {   //错误码设置出错，停止线程
                        bstop = true;
                        break;
                    }
                    //连接成功，开始休眠
                    try
                    {
                        Monitor.Enter(objLock);
                        {
                            lastSleepTime = DateTime.Now.Ticks;

                            Monitor.Wait(objLock, conf.GetHttpReconnectInterval() * 1000);
                            if (DateTime.Now.Ticks - lastSleepTime >= (conf.GetHttpReconnectInterval()) * 1000 * 10000)
                            {
                                /*
                                 * 快要到达连接的最大时间了，需要重新发起连接
                                 */
                                serverRespCode = StreamConstants.RECONNECT;
                                isReconnect = true;
                            }//否则，是由于某种原因被唤醒的
                        }
                    }
                    catch (Exception e)
                    {
                        logger.Error(e.Message);
                    }
                    finally
                    {
                        Monitor.Exit(objLock);
                    }
                }
                catch (Exception e)
                {
                    logger.Error("Occur some error,stop the stream consume" + e.Message);
                    bstop = true;
                    try
                    {
                        Monitor.Enter(objLock);
                        Monitor.PulseAll(objLock);
                    }
                    finally
                    {
                        Monitor.Exit(objLock);
                    }
                }
            }
            if (currentStreamImpl != null)
            {
                try
                {
                    currentStreamImpl.Close();
                }
                catch (Exception e)
                {
                    // ignore
                }
            }
            logger.Info("Stop stream consume");
        }

        private void StartConsumeThread(TopCometStreamRequest cometReq)
        {
            IStreamImplementation stream = null;
            try
            {
                stream = GetMsgStreamImpl(cometReq);
                if (cometReq.GetConnectListener() != null)
                {
                    cometReq.GetConnectListener().OnConnect();
                }
            }
            catch (TopCometSysErrorException e)
            {
                bstop = true;
                logger.Error(e.Message);
                if (cometReq.GetConnectListener() != null)
                {
                    cometReq.GetConnectListener().OnSysErrorException(e);
                }
            }
            catch (Exception ex)
            {
                bstop = true;
                logger.Error(ex.Message);
                if (cometReq.GetConnectListener() != null)
                {
                    cometReq.GetConnectListener().OnConnectError(ex);
                }
            }

            lastStartConsumeThread = DateTime.Now.Ticks;
            
            Thread TopCometStreamConsumeThread = new Thread(delegate()
                {
                    TopCometStreamConsume(lastStartConsumeThread, ref bstop, stream, cometReq.GetConnectListener());
                });
            TopCometStreamConsumeThread.Name = "top-stream-consume-thread" + cometReq.GetConnectId();
            TopCometStreamConsumeThread.Start();
        }

        public IStreamImplementation GetMsgStreamImpl(TopCometStreamRequest cometReq)
        {
            if (cometReq != null)
            {
                cometReq.GetConnectListener().OnBeforeConnect();
            }

            TopDictionary param = new TopDictionary();
            param.Add(StreamConstants.PARAM_APPKEY, cometReq.GetAppkey());
            if (!String.IsNullOrEmpty(cometReq.GetUserId()))
            {
                param.Add(StreamConstants.PARAM_USERID, cometReq.GetUserId());
            }
            if (!String.IsNullOrEmpty(cometReq.GetConnectId()))
            {
                param.Add(StreamConstants.PARAM_CONNECT_ID, cometReq.GetConnectId());
            }
            param.Add(StreamConstants.PARAM_TIMESTAMP, DateTime.Now.Ticks);

            IDictionary<string, string> otherParam = cometReq.GetOtherParam();
            if (otherParam != null && otherParam.Count > 0)
            {
                IEnumerator<KeyValuePair<string, string>> kvps = otherParam.GetEnumerator();
                while (kvps.MoveNext())
                {
                    param.Add(kvps.Current.Key, kvps.Current.Value);
                }
            }

            string sign = null;
            try
            {
                sign = TopUtils.SignTopRequest(param, cometReq.GetSecret(), true);
                if (String.IsNullOrEmpty(sign))
                {
                    throw new Exception("Get sign error");
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            param.Add(StreamConstants.PARAM_SIGN, sign);
            HttpClient httpClient = new HttpClient(conf, param);
            HttpResponse response;
            response = httpClient.Post();
            return currentStreamImpl = new MessageStreamImpl(msgConsumeFactory, response, cometMessageListener, this);
        }

        void TopCometStreamConsume(long lastStartConsumeThread, ref bool bstop, IStreamImplementation stream, IConnectionLifeCycleListener connectListener)
        {
            startConsumeThreadTimes = 0;
            while (!allStop&&!closed && stream.IsAlive())
            {
                try
                {
                    stream.NextMsg();
                }
                catch (Exception e)
                {//出现了read time out异常
                    // 资源清理
                    if (stream != null)
                    {
                        try
                        {
                            stream.Close();
                        }
                        catch (Exception e1)
                        {
                            logger.Error(e1.Message);
                        }
                    }
                    stream = null;
                    closed = true;
                    //通知
                    if (connectionListener != null)
                    {
                        try
                        {
                            connectionListener.OnReadTimeout();
                        }
                        catch (Exception ex)
                        {
                            logger.Error(ex.Message);
                        }
                    }
                    /**
                     * 30分钟内发送了10次IOException
                     */
                    if (DateTime.Now.Ticks - lastStartConsumeThread < 18000000000)
                    {// 短时间内由于读取IOException连接了10次，则退出
                        startConsumeThreadTimes++;
                        if (startConsumeThreadTimes >= 10)
                        {
                            bstop = true;
                            if (connectionListener != null)
                            {
                                try
                                {
                                    connectionListener.OnMaxReadTimeoutException();
                                }
                                catch (Exception maxE) { logger.Error(maxE.Message); }
                            }
                            logger.Error("Occure too many exception,stop the system,please check");
                            //通知唤醒控制线程，但是不在发起重连接
                            try
                            {
                                Monitor.Enter(objLock);
                                Monitor.PulseAll(objLock);
                            }
                            catch (Exception e2)
                            {
                            }
                            finally
                            {
                                Monitor.Exit(objLock);
                            }
                        }
                        else
                        {   //没有到达10次，通知重连
                            startConsumeThreadTimes = 0;
                            serverRespCode = StreamConstants.RECONNECT;
                            try
                            {
                                Monitor.Enter(objLock);
                                Monitor.PulseAll(objLock);
                            }
                            catch (Exception e2)
                            {
                            }
                            finally
                            {
                                Monitor.Exit(objLock);
                            }
                            closed = false;
                            break;
                        }
                    }
                    else
                    {
                        // 通知重连
                        Console.WriteLine(" 通知重连" + DateTime.Now.ToString());
                        startConsumeThreadTimes = 0;
                        serverRespCode = StreamConstants.RECONNECT;

                        try
                        {
                            Monitor.Enter(objLock);
                            Console.WriteLine(" PulseAll" + DateTime.Now.ToString());
                            Monitor.PulseAll(objLock);
                        }
                        catch (Exception e2)
                        {
                        }
                        finally
                        {
                            Monitor.Exit(objLock);
                        }
                        closed = false;
                        break;
                    }
                }
            }
            //出现异常情况下做资源清理
            if (stream != null)
            {
                try
                {
                    stream.Close();
                }
                catch (Exception e)
                {
                    logger.Warn(e.Message);
                }
            }
        }

        public void Stop()
        {
            allStop = true;
            try
            {
                Monitor.Enter(objLock);
                Monitor.PulseAll(objLock);
            }
            catch (Exception e)
            {
            }
            finally
            {
                Monitor.Exit(objLock);
            }
        }

        public object GetControlLock()
        {
            return objLock;
        }

        public void SetServerRespCode(string serverRespCode)
        {
            this.serverRespCode = serverRespCode;
        }
    }
}
