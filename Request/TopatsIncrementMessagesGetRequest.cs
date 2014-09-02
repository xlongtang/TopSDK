using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.topats.increment.messages.get
    /// </summary>
    public class TopatsIncrementMessagesGetRequest : ITopRequest<TopatsIncrementMessagesGetResponse>
    {
        /// <summary>
        /// 消息结束时间，格式：yyyy-MM-dd HH:mm:ss，其中start < end < 现在，并且start和end在同一天。
        /// </summary>
        public Nullable<DateTime> End { get; set; }

        /// <summary>
        /// 消息开始时间，格式：yyyy-MM-dd HH:mm:ss，其中start >= 前天零点
        /// </summary>
        public Nullable<DateTime> Start { get; set; }

        /// <summary>
        /// 消息类型，多个类型之间用半角逗号分隔，可选值为：item,trade,refund。
        /// </summary>
        public string Topics { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.topats.increment.messages.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end", this.End);
            parameters.Add("start", this.Start);
            parameters.Add("topics", this.Topics);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("end", this.End);
            RequestValidator.ValidateRequired("start", this.Start);
            RequestValidator.ValidateRequired("topics", this.Topics);
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
