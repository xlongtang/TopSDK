using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.tmc.message.produce
    /// </summary>
    public class TmcMessageProduceRequest : ITopRequest<TmcMessageProduceResponse>
    {
        /// <summary>
        /// 消息内容的JSON表述，必须按照topic的定义来填充
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 消息的扩增属性，用json格式表示
        /// </summary>
        public string ExContent { get; set; }

        /// <summary>
        /// 直发消息需要传入目标appkey
        /// </summary>
        public string TargetAppkey { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        public string Topic { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.tmc.message.produce";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("content", this.Content);
            parameters.Add("ex_content", this.ExContent);
            parameters.Add("target_appkey", this.TargetAppkey);
            parameters.Add("topic", this.Topic);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("content", this.Content);
            RequestValidator.ValidateMaxLength("content", this.Content, 2000);
            RequestValidator.ValidateMaxLength("ex_content", this.ExContent, 500);
            RequestValidator.ValidateMaxLength("target_appkey", this.TargetAppkey, 256);
            RequestValidator.ValidateRequired("topic", this.Topic);
            RequestValidator.ValidateMaxLength("topic", this.Topic, 256);
        }

        #endregion

        public void AddOtherParameter(string key, string value)
        {
            if (this.otherParameters == null)
            {
                this.otherParameters = new TopDictionary();
            }
            this.otherParameters.Add(key, value);
        }
    }
}
