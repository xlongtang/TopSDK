using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.tmc.messages.consume
    /// </summary>
    public class TmcMessagesConsumeRequest : ITopRequest<TmcMessagesConsumeResponse>
    {
        /// <summary>
        /// 用户分组名称，不传表示消费默认分组，如果应用没有设置用户分组，传入分组名称将会返回错误
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 每次批量消费消息的条数<br /> 支持最大值为：200<br /> 支持最小值为：10
        /// </summary>
        public Nullable<long> Quantity { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.tmc.messages.consume";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("group_name", this.GroupName);
            parameters.Add("quantity", this.Quantity);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("quantity", this.Quantity, 200);
            RequestValidator.ValidateMinValue("quantity", this.Quantity, 10);
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
