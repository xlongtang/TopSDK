using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using Jayrock.Json.Conversion;
using Top.Api.Parser;
using Top.Api.Request;
using Top.Api.Util;
using System.Text;

namespace Top.Api
{
    /// <summary>
    /// 基于REST的TOP客户端。
    /// </summary>
    public class DefaultTopClient : ITopClient
    {
        public const string APP_KEY = "app_key";
        public const string FORMAT = "format";
        public const string METHOD = "method";
        public const string TIMESTAMP = "timestamp";
        public const string VERSION = "v";
        public const string SIGN = "sign";
        public const string PARTNER_ID = "partner_id";
        public const string SESSION = "session";
        public const string FORMAT_XML = "xml";
        public const string SDK_VERSION = "top-sdk-net-20150212"; // SDK自动生成会替换成真实的版本

        private string serverUrl;
        private string appKey;
        private string appSecret;
        private string format = FORMAT_XML;

        private WebUtils webUtils;
        private ITopLogger topLogger;
        private bool disableParser = false; // 禁用响应结果解释
        private bool disableTrace = false; // 禁用日志调试功能
        private IDictionary<string, string> systemParameters; // 设置所有请求共享的系统级参数

        #region DefaultTopClient Constructors

        public DefaultTopClient(string serverUrl, string appKey, string appSecret)
        {
            this.appKey = appKey;
            this.appSecret = appSecret;
            this.serverUrl = serverUrl;
            this.webUtils = new WebUtils();
            this.topLogger = new DefaultTopLogger();
        }

        public DefaultTopClient(string serverUrl, string appKey, string appSecret, string format)
            : this(serverUrl, appKey, appSecret)
        {
            this.format = format;
        }

        #endregion


        public void SetTopLogger(ITopLogger topLogger)
        {
            this.topLogger = topLogger;
        }

        public void SetTimeout(int timeout)
        {
            this.webUtils.Timeout = timeout;
        }

        public void SetDisableParser(bool disableParser)
        {
            this.disableParser = disableParser;
        }

        public void SetDisableTrace(bool disableTrace)
        {
            this.disableTrace = disableTrace;
        }

        public void SetSystemParameters(IDictionary<string, string> systemParameters)
        {
            this.systemParameters = systemParameters;
        }

        #region ITopClient Members

        public T Execute<T>(ITopRequest<T> request) where T : TopResponse
        {
            return Execute<T>(request, null);
        }

        public T Execute<T>(ITopRequest<T> request, string session) where T : TopResponse
        {
            return Execute<T>(request, session, DateTime.Now);
        }

        public T Execute<T>(ITopRequest<T> request, string session, DateTime timestamp) where T : TopResponse
        {
            return DoExecute<T>(request, session, timestamp);
        }

        #endregion

        private T DoExecute<T>(ITopRequest<T> request, string session, DateTime timestamp) where T : TopResponse
        {
            // 提前检查业务参数
            try
            {
                request.Validate();
            }
            catch (TopException e)
            {
                return CreateErrorResponse<T>(e.ErrorCode, e.ErrorMsg);
            }

            // 添加协议级请求参数
            TopDictionary txtParams = new TopDictionary(request.GetParameters());
            txtParams.Add(METHOD, request.GetApiName());
            txtParams.Add(VERSION, "2.0");
            txtParams.Add(APP_KEY, appKey);
            txtParams.Add(FORMAT, format);
            txtParams.Add(PARTNER_ID, SDK_VERSION);
            txtParams.Add(TIMESTAMP, timestamp);
            txtParams.Add(SESSION, session);
            txtParams.AddAll(this.systemParameters);

            // 添加签名参数
            txtParams.Add(SIGN, TopUtils.SignTopRequest(txtParams, appSecret));

            string reqUrl = webUtils.BuildGetUrl(this.serverUrl, txtParams);
            try
            {
                string body;
                if (request is ITopUploadRequest<T>) // 是否需要上传文件
                {
                    ITopUploadRequest<T> uRequest = (ITopUploadRequest<T>)request;
                    IDictionary<string, FileItem> fileParams = TopUtils.CleanupDictionary(uRequest.GetFileParameters());
                    body = webUtils.DoPost(this.serverUrl, txtParams, fileParams);
                }
                else
                {
                    body = webUtils.DoPost(this.serverUrl, txtParams);
                }

                // 解释响应结果
                T rsp;
                if (disableParser)
                {
                    rsp = Activator.CreateInstance<T>();
                    rsp.Body = body;
                }
                else
                {
                    if (FORMAT_XML.Equals(format))
                    {
                        ITopParser tp = new TopXmlParser();
                        rsp = tp.Parse<T>(body);
                    }
                    else
                    {
                        ITopParser tp = new TopJsonParser();
                        rsp = tp.Parse<T>(body);
                    }
                }

                // 追踪错误的请求
                if (!disableTrace && rsp.IsError)
                {
                    StringBuilder sb = new StringBuilder(reqUrl).Append(" response error!\r\n").Append(rsp.Body);
                    topLogger.Warn(sb.ToString());
                }
                return rsp;
            }
            catch (Exception e)
            {
                if (!disableTrace)
                {
                    StringBuilder sb = new StringBuilder(reqUrl).Append(" request error!\r\n").Append(e.StackTrace);
                    topLogger.Error(sb.ToString());
                }
                throw e;
            }
        }

        private T CreateErrorResponse<T>(string errCode, string errMsg) where T : TopResponse
        {
            T rsp = Activator.CreateInstance<T>();
            rsp.ErrCode = errCode;
            rsp.ErrMsg = errMsg;

            if (FORMAT_XML.Equals(format))
            {
                XmlDocument root = new XmlDocument();
                XmlElement bodyE = root.CreateElement("error_response");
                XmlElement codeE = root.CreateElement("code");
                codeE.InnerText = errCode;
                bodyE.AppendChild(codeE);
                XmlElement msgE = root.CreateElement("msg");
                msgE.InnerText = errMsg;
                bodyE.AppendChild(msgE);
                root.AppendChild(bodyE);
                rsp.Body = root.OuterXml;
            }
            else
            {
                IDictionary<string, object> errObj = new Dictionary<string, object>();
                errObj.Add("code", errCode);
                errObj.Add("msg", errMsg);
                IDictionary<string, object> root = new Dictionary<string, object>();
                root.Add("error_response", errObj);

                string body = JsonConvert.ExportToString(root);
                rsp.Body = body;
            }
            return rsp;
        }
    }
}
