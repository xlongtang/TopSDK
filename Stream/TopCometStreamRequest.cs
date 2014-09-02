using System;
using System.Collections.Generic;
using System.Net;
using Top.Api.Stream.Connect;
using Top.Api.Stream.Message;
using System.Diagnostics;

namespace Top.Api.Stream
{
    public class TopCometStreamRequest
    {
        private string appkey;
        private string secret;
        private string userId;
        private string connectId;
        private IConnectionLifeCycleListener connectListener;
        private ITopCometMessageListener msgListener;
        private IDictionary<string, string> otherParam;

        public TopCometStreamRequest(string appkey, string secret, string userId, string connectId)
        {
            if (String.IsNullOrEmpty(appkey))
            {
                throw new Exception("appkey is null");
            }
            if (String.IsNullOrEmpty(secret))
            {
                throw new Exception("secret is null");
            }
            if (!String.IsNullOrEmpty(userId))
            {
                try
                {
                    long.Parse(userId);
                }
                catch (Exception e)
                {
                    throw new Exception("userid must a number type");
                }
            }
            else
            {
                userId = "-1";
            }

            if (String.IsNullOrEmpty(connectId))
            {
                this.connectId = GetDefaultConnectId();
            }
            else
            {
                this.connectId = connectId;
            }
            this.appkey = appkey;
            this.secret = secret;
            this.userId = userId;

        }
        private static string GetDefaultConnectId()
        {
            return Dns.GetHostName() + "-" + Process.GetCurrentProcess().Id;
        }
        public string GetAppkey()
        {
            return appkey;
        }
        public string GetSecret()
        {
            return secret;
        }
        public string GetUserId()
        {
            return userId;
        }

        public string GetConnectId()
        {
            return connectId;
        }
        public IConnectionLifeCycleListener GetConnectListener()
        {
            return connectListener;
        }
        public void SetConnectListener(IConnectionLifeCycleListener connectListener)
        {
            this.connectListener = connectListener;
        }
        public ITopCometMessageListener GetMsgListener()
        {
            return msgListener;
        }
        public void SetMsgListener(ITopCometMessageListener msgListener)
        {
            this.msgListener = msgListener;
        }
        public IDictionary<string, string> GetOtherParam()
        {
            return otherParam;
        }
        public void SetOtherParam(IDictionary<string, string> otherParam)
        {
            this.otherParam = otherParam;
        }
    }
}
