using System;
using System.Collections.Generic;
using Top.Api.Stream.Connect;
using Top.Api.Stream.Message;

/**
 * 初始化stream client需要的一些配置
 **/
namespace Top.Api.Stream
{
    public class Configuration : IHttpConnectionConfiguration, IMessageHandlerConfiguration
    {
        private string connectUrl = "http://stream.api.taobao.com/stream";
        private int httpConnectionTimeout = 5;//默认连接超时时间5s

        /*
         * 由于服务端会间隔1分钟会发送一个心跳包，所以超时间比1分钟稍多点，使用者最好不要修改这个参数
         */
        private int httpReadTimeout = 60 + 30;//90s
        private int httpConnectRetryCount = 3;//默认重试3次
        private int httpConnectRetryInterval = 16;//16s
        private int sleepTimeOfServerInUpgrade = 5 * 60;//当服务端在发布的时候休眠的时间，默认5分钟，
        private IDictionary<String, String> reqHeader;
        /*
         * 因为服务端目前在24小时后会断开连接，所以为了最低程度的降低消息丢失，在服务端断开之间客户端重连一次
         * 默认是23小时加55分钟后自动重连
         */
        private int httpReconnectInterval = (23 * 60 + 55) * 60;

        private int minThreads = 100;
        private int maxThreads = 200;
        /*
         * 假设每条消息为1k大小，队列里可以存大约50M的数据
         */
        private int queueSize = 50000;

        private List<TopCometStreamRequest> connectReqParam;

        /**
         * 1，userid是用户的id，是大于0的整数。
         * 如果不需要传入userid，则可以传入小于等于0的数值。
         * </br>
         * 2，如果不指定userid，则所有与此appkey关联的所有用户的消息都会发送到此连接上</br>
         * @param appkey
         * @param secret
         * @param userid 传入用户的userid
         */
        public Configuration(string appkey, string secret, string userid)
        {
            TopCometStreamRequest cometReq = new TopCometStreamRequest(appkey, secret, userid, null);
            connectReqParam = new List<TopCometStreamRequest>(1);
            connectReqParam.Add(cometReq);
        }

        /**
         * 1，userid是用户的id，是大于0的整数。
         * 如果不需要传入userid，则可以传入小于等于0的数值。
         * </br>
         * 2，如果不指定userid，则所有与此appkey关联的所有用户的消息都会发送到此连接上</br>
         * 3，connectId为连接标识（用于多连接）。可以为空。对于多连接的详细描述请参考文档。
         * @param appkey
         * @param secret
         * @param userid 传入用户的userid
         * @param connectId 连接标识
         */
        public Configuration(string appkey, string secret, string userid, string connectId)
        {
            TopCometStreamRequest cometReq = new TopCometStreamRequest(appkey, secret, userid, connectId);
            connectReqParam = new List<TopCometStreamRequest>(1);
            connectReqParam.Add(cometReq);
        }

        /**
         * 用于多连接
         * @param cometRequest
         */
        public Configuration(List<TopCometStreamRequest> cometRequest)
        {
            if (cometRequest == null || (cometRequest != null && cometRequest.Count == 0))
            {
                throw new Exception("comet request param is null");
            }
            this.connectReqParam = cometRequest;
        }

        public List<TopCometStreamRequest> GetConnectReqParam()
        {
            return this.connectReqParam;
        }

        //http connection config
        public void SetHttpConnectionTimeout(int httpConnectionTimeout)
        {
            this.httpConnectionTimeout = httpConnectionTimeout;
        }
        public int GetHttpConnectionTimeout()
        {
            return httpConnectionTimeout;
        }
        public int GetHttpReadTimeout()
        {
            return httpReadTimeout;
        }

        /**
         * 由于服务端会间隔约30秒会发送一个心跳包，所以超时间比1分钟稍多点，使用者最好不要修改这个参数
         * @param httpReadTimeout
         */
        public void SetHttpReadTimeout(int httpReadTimeout)
        {
            this.httpReadTimeout = httpReadTimeout;
        }
        public void SetHttpConnectRetryCount(int httpConnectRetryCount)
        {
            this.httpConnectRetryCount = httpConnectRetryCount;
        }
        public int GetHttpConnectRetryCount()
        {
            return httpConnectRetryCount;
        }

        /**
         * 方便测试使用，生成环境请不要调用此方法
         * @param connectUrl
         */
        public void SetConnectUrl(string connectUrl)
        {
            this.connectUrl = connectUrl;
        }
        public string GetConnectUrl()
        {
            return connectUrl;
        }
        public void SetHttpConnectRetryInterval(int httpConnectRetryInterval)
        {
            this.httpConnectRetryInterval = httpConnectRetryInterval;
        }
        public int GetHttpConnectRetryInterval()
        {
            return httpConnectRetryInterval;
        }
        public void SetSleepTimeOfServerInUpgrade(int sleepSecond)
        {
            this.sleepTimeOfServerInUpgrade = sleepSecond;
        }
        public int GetSleepTimeOfServerInUpgrade()
        {
            return sleepTimeOfServerInUpgrade;
        }

        /*
         * 因为服务端目前在24小时后会断开连接，所以为了最低程度的降低消息丢失，在服务端断开之间客户端重连一次(non-Javadoc)
         */
        public void SetHttpReconnectInterval(int httpReconnectInterval)
        {
            this.httpReconnectInterval = httpReconnectInterval;
        }
        public int GetHttpReconnectInterval()
        {
            return httpReconnectInterval;
        }
        public void SetRequestHeader(IDictionary<string, string> reqHeader)
        {
            this.reqHeader = reqHeader;
        }
        public IDictionary<string, string> GetRequestHeader()
        {
            return reqHeader;
        }
        public void SetMinThreads(int minThreads)
        {
            this.minThreads = minThreads;
        }
        public int GetMinThreads()
        {
            return minThreads;
        }
        public void SetMaxThreads(int maxThreads)
        {
            this.maxThreads = maxThreads;
        }
        public int GetMaxThreads()
        {
            return maxThreads;
        }
        public void SetQueueSize(int queueSize)
        {
            this.queueSize = queueSize;
        }
        public int GetQueueSize()
        {
            return queueSize;
        }

    }
}
