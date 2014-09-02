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
        /// 消息内容的JSON表述，必须按照topic的定义来填充<br /> 支持最大长度为：2000<br /> 支持的最大列表长度为：2000
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 发布消息关联的主题<br /> 支持最大长度为：256<br /> 支持的最大列表长度为：256
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
            parameters.Add("topic", this.Topic);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("content", this.Content);
            RequestValidator.ValidateMaxLength("content", this.Content, 2000);
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
