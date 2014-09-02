using System;
using System.Text.RegularExpressions;
using System.Threading;
using Top.Api.Stream.Connect;

namespace Top.Api.Stream.Message
{
    public class MessageStreamImpl : AbstractStreamImpl
    {
        private ITopLogger logger = new DefaultTopLogger();
        private ITopCometMessageListener msgListener;
        private TopCometStreamImpl cometStreamImpl;
        private string pattern = "\\{\"packet\":\\{\"code\":(?<code>(\\d+))(,\"msg\":(?<msg>((.+))))?\\}\\}";
        private object objLock = new object();

        public MessageStreamImpl(StreamMsgConsumeFactory msgConsumeFactory,
                HttpResponse response, ITopCometMessageListener msgListener, TopCometStreamImpl cometStreamImpl)
            : base(msgConsumeFactory, response)
        {
            this.msgListener = msgListener;
            this.objLock = cometStreamImpl.GetControlLock();
            this.cometStreamImpl = cometStreamImpl;
        }

        public override string ParseLine(string msg)
        {
            if (!string.IsNullOrEmpty(msg))
            {
                try
                {
                    Regex rg = new Regex(pattern, RegexOptions.Compiled);
                    MatchCollection matches = rg.Matches(msg);

                    if (matches.Count > 0)
                    {
                        string code = matches[0].Groups["code"].Value;

                        if (StreamConstants.NEW_MESSAGE.Equals(code))
                        {
                            return matches[0].Groups["msg"].Value; 
                        }
                        else if (StreamConstants.HEAT_BEAT.Equals(code))
                        {
                            msgListener.OnHeartBeat();
                        }
                        else if (StreamConstants.CONNECT_REACH_MAX_TIME.Equals(code))
                        {
                            msgListener.OnConnectReachMaxTime();
                            WakeUp(code);
                        }
                        else if (StreamConstants.DISCARD_MESSAGE.Equals(code))
                        {
                            msgListener.OnDiscardMsg(matches[0].Groups["msg"].Value.ToString());
                        }
                        else if (StreamConstants.SERVER_DEPLOY.Equals(code))
                        {
                            msgListener.OnServerUpgrade(matches[0].Groups["msg"].Value.ToString());
                            WakeUp(code);
                        }
                        else if (StreamConstants.SERVER_REHASH.Equals(code))
                        {
                            msgListener.OnServerRehash();
                            WakeUp(code);
                        }
                        else if (StreamConstants.CLIENT_KICKOFF.Equals(code))
                        {
                            msgListener.OnClientKickOff();
                            WakeUp(code);
                        }
                        else if (StreamConstants.SERVER_KICKOFF.Equals(code))
                        {
                            msgListener.OnServerKickOff();
                            WakeUp(code);
                        }
                        else if (StreamConstants.CONNECT_SUCCESS.Equals(code))
                        {
                            msgListener.OnConnectMsg(matches[0].Groups["msg"].Value);
                        }
                        else
                        {
                            msgListener.OnOtherMsg(matches[0].Groups["msg"].Value);
                        }
                    }
                }
                catch (Exception e)
                {
                    logger.Error("Message is invalid:" + msg + e.Message);
                    msgListener.OnException(e);
                    return null;
                }
            }
            return null;
        }

        private void WakeUp(string code)
        {
            try
            {
                Monitor.Enter(objLock);
                cometStreamImpl.SetServerRespCode(code);
                Monitor.PulseAll(objLock);
            }
            catch (Exception e)
            {
                //ignore
            }
            finally
            {
                Monitor.Exit(objLock);
            }
        }

        public override ITopCometMessageListener GetMessageListener()
        {
            return this.msgListener;
        }

        public override void OnException(Exception ex)
        {
            logger.Error(ex.Message);
        }

        public override void Close()
        {
            streamAlive = false;
        }
    }
}
