using System;
using System.Threading;
using Top.Api.Request;

namespace Top.Api
{
    /// <summary>
    /// 调用出错自动重试客户端。
    /// </summary>
    public class AutoRetryTopClient : DefaultTopClient
    {
        private static readonly TopException RETRY_FAIL = new TopException("sdk.retry-call-fail", "API调用重试失败");

        [ThreadStatic]
        private static int retryCounter = -1;

        /// <summary>
        /// 单次请求的最大重试次数，默认值为3次。
        /// </summary>
        private int maxRetryCount = 3;
        /// <summary>
        /// 重试之前休眠时间，默认值为500毫秒。
        /// </summary>
        private int retryWaitTime = 500;
        /// <summary>
        /// 超过最大重试次数时是否抛出异常。
        /// </summary>
        private bool throwIfOverMaxRetry = false;

        public AutoRetryTopClient(string serverUrl, string appKey, string appSecret)
            : base(serverUrl, appKey, appSecret)
        {
        }

        public AutoRetryTopClient(string serverUrl, string appKey, string appSecret, string format)
            : base(serverUrl, appKey, appSecret, format)
        {
        }

        public new T Execute<T>(ITopRequest<T> request) where T : TopResponse
        {
            return Execute<T>(request, null);
        }

        public new T Execute<T>(ITopRequest<T> request, string session) where T : TopResponse
        {
            return Execute<T>(request, session, DateTime.Now);
        }

        public new T Execute<T>(ITopRequest<T> request, string session, DateTime timestamp) where T : TopResponse
        {
            T rsp = null;
            try
            {
                retryCounter++;
                rsp = base.Execute(request, session, timestamp);
                if (rsp.IsError)
                {
                    if (retryCounter < maxRetryCount)
                    {
                        if (rsp.SubErrCode != null && rsp.SubErrCode.StartsWith("isp."))
                        {
                            Thread.Sleep(retryWaitTime);
                            return Execute(request, session, timestamp);
                        }
                    }
                    else
                    {
                        if (throwIfOverMaxRetry)
                        {
                            throw RETRY_FAIL;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                if (e != RETRY_FAIL && retryCounter < maxRetryCount)
                {
                    Thread.Sleep(retryWaitTime);
                    return Execute(request, session, timestamp);
                }
            }
            finally
            {
                retryWaitTime = -1;
            }
            return rsp;
        }

        public void SetMaxRetryCount(int maxRetryCount)
        {
            this.maxRetryCount = maxRetryCount;
        }

        public void SetRetryWaitTime(int retryWaitTime)
        {
            this.retryWaitTime = retryWaitTime;
        }

        public void SetThrowIfOverMaxRetry(bool throwIfOverMaxRetry)
        {
            this.throwIfOverMaxRetry = throwIfOverMaxRetry;
        }
    }
}
