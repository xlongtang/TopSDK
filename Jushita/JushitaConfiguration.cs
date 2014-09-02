using System;
using System.Collections.Generic;
using System.Text;
using Top.Api.Stream;
using Top.Api.Stream.Connect;

namespace Top.Api.Jushita
{
    public abstract class JushitaConfiguration : Configuration
    {
        private const string SERVER_URL = "http://synccenter.taobao.com/message/sub";

        public IConnectionLifeCycleListener ConnectionLifeCycleListener { get; set; }

        public JushitaConfiguration(string appKey, string appSecret, string connectId)
            : base(appKey, appSecret, null, connectId)
        {
            base.SetConnectUrl(SERVER_URL);
            // 为保证完全顺序的消费，默认把消费线程池线程数设置为1
            base.SetMinThreads(1);
            base.SetMaxThreads(1);
            foreach (TopCometStreamRequest cometReq in base.GetConnectReqParam())
            {
                cometReq.SetConnectListener(new JushitaConnectionLifeCycleListener(this));
            }
        }

        public void SetTopicInfo(List<string> topicInfoList)
        {
            StringBuilder topics = new StringBuilder();
            foreach (string topic in topicInfoList)
            {
                if (topics.Length > 0)
                {
                    topics.Append(";");
                }
                topics.Append(topic);
            }
            if (base.GetConnectReqParam().Count > 1)
            {
                throw new Exception("配置状态不正常，连接配置大于1个");
            }
            foreach (TopCometStreamRequest cometReq in base.GetConnectReqParam())
            {
                if (cometReq.GetOtherParam() == null)
                {
                    cometReq.SetOtherParam(new Dictionary<string, string>());
                }
                cometReq.GetOtherParam().Add("topic", topics.ToString());
            }
        }

        public abstract List<string> GetTopicInfo();
    }

    public class JushitaConnectionLifeCycleListener : IConnectionLifeCycleListener
    {
        private JushitaConfiguration conf;

        public JushitaConnectionLifeCycleListener(JushitaConfiguration conf)
        {
            this.conf = conf;
        }

        public void OnBeforeConnect()
        {
            if (conf.ConnectionLifeCycleListener != null)
            {
                conf.ConnectionLifeCycleListener.OnBeforeConnect();
            }
            List<string> topics = conf.GetTopicInfo();
            if (topics == null || topics.Count == 0)
            {
                throw new Exception("topic info is empty");
            }
            conf.SetTopicInfo(topics);
        }

        public void OnConnect()
        {
            if (conf.ConnectionLifeCycleListener != null)
            {
                conf.ConnectionLifeCycleListener.OnConnect();
            }
        }

        public void OnException(Exception e)
        {
            if (conf.ConnectionLifeCycleListener != null)
            {
                conf.ConnectionLifeCycleListener.OnException(e);
            }
        }

        public void OnConnectError(Exception e)
        {
            if (conf.ConnectionLifeCycleListener != null)
            {
                conf.ConnectionLifeCycleListener.OnConnectError(e);
            }
        }

        public void OnReadTimeout()
        {
            if (conf.ConnectionLifeCycleListener != null)
            {
                conf.ConnectionLifeCycleListener.OnReadTimeout();
            }
        }

        public void OnMaxReadTimeoutException()
        {
            if (conf.ConnectionLifeCycleListener != null)
            {
                conf.ConnectionLifeCycleListener.OnMaxReadTimeoutException();
            }
        }

        public void OnSysErrorException(Exception e)
        {
            if (conf.ConnectionLifeCycleListener != null)
            {
                conf.ConnectionLifeCycleListener.OnSysErrorException(e);
            }
        }
    }
}
