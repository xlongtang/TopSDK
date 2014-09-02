using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.order.consign
    /// </summary>
    public class WlbOrderConsignRequest : ITopRequest<WlbOrderConsignResponse>
    {
        /// <summary>
        /// 物流宝订单编号<br /> 支持最大长度为：64<br /> 支持的最大列表长度为：64
        /// </summary>
        public string WlbOrderCode { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.order.consign";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("wlb_order_code", this.WlbOrderCode);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("wlb_order_code", this.WlbOrderCode);
            RequestValidator.ValidateMaxLength("wlb_order_code", this.WlbOrderCode, 64);
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
