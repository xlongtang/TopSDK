using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alipay.micropay.order.get
    /// </summary>
    public class AlipayMicropayOrderGetRequest : ITopRequest<AlipayMicropayOrderGetResponse>
    {
        /// <summary>
        /// 支付宝订单号，冻结流水号(创建冻结订单返回)
        /// </summary>
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 支付宝用户给应用的授权.
        /// </summary>
        public string AuthToken { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alipay.micropay.order.get";
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
