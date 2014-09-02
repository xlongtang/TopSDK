using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alipay.micropay.order.freezepayurl.get
    /// </summary>
    public class AlipayMicropayOrderFreezepayurlGetRequest : ITopRequest<AlipayMicropayOrderFreezepayurlGetResponse>
    {
        /// <summary>
        /// 冻结订单号,创建冻结订单时支付宝返回的
        /// </summary>
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 支付宝用户给应用的授权。
        /// </summary>
        public string AuthToken { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alipay.micropay.order.freezepayurl.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("alipay_order_no", this.AlipayOrderNo);
            parameters.Add("auth_token", this.AuthToken);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("alipay_order_no", this.AlipayOrderNo);
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
