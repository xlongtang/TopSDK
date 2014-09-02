using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.orderschedulerule.delete
    /// </summary>
    public class WlbOrderscheduleruleDeleteRequest : ITopRequest<WlbOrderscheduleruleDeleteResponse>
    {
        /// <summary>
        /// 订单调度规则ID<br /> 支持的最大列表长度为：20
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 商品userNick<br /> 支持最大长度为：64<br /> 支持的最大列表长度为：64
        /// </summary>
        public string UserNick { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.orderschedulerule.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("user_nick", this.UserNick);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", this.Id);
            RequestValidator.ValidateRequired("user_nick", this.UserNick);
            RequestValidator.ValidateMaxLength("user_nick", this.UserNick, 64);
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
