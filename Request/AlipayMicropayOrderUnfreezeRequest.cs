using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alipay.micropay.order.unfreeze
    /// </summary>
    public class AlipayMicropayOrderUnfreezeRequest : ITopRequest<AlipayMicropayOrderUnfreezeResponse>
    {
        /// <summary>
        /// 冻结资金流水号,在创建资金订单时支付宝返回的流水号
        /// </summary>
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 支付宝用户给应用的授权.
        /// </summary>
        public string AuthToken { get; set; }

        /// <summary>
        /// 冻结备注
        /// </summary>
        public string Memo { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alipay.micropay.order.unfreeze";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("alipay_order_no", this.AlipayOrderNo);
            parameters.Add("auth_token", this.AuthToken);
            parameters.Add("memo", this.Memo);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("alipay_order_no", this.AlipayOrderNo);
            RequestValidator.ValidateRequired("memo", this.Memo);
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
