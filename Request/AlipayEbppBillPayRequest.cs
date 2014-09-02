using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alipay.ebpp.bill.pay
    /// </summary>
    public class AlipayEbppBillPayRequest : ITopRequest<AlipayEbppBillPayResponse>
    {
        /// <summary>
        /// 支付宝的业务订单号，具有唯一性。
        /// </summary>
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 如有有淘宝授权的session可以不传这个字段
        /// </summary>
        public string AuthToken { get; set; }

        /// <summary>
        /// 输出机构的业务流水号，需要保证唯一性。
        /// </summary>
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 支付宝订单类型。公共事业缴纳JF,信用卡还款HK
        /// </summary>
        public string OrderType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alipay.ebpp.bill.pay";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("alipay_order_no", this.AlipayOrderNo);
            parameters.Add("auth_token", this.AuthToken);
            parameters.Add("merchant_order_no", this.MerchantOrderNo);
            parameters.Add("order_type", this.OrderType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("alipay_order_no", this.AlipayOrderNo);
            RequestValidator.ValidateMaxLength("alipay_order_no", this.AlipayOrderNo, 28);
            RequestValidator.ValidateRequired("merchant_order_no", this.MerchantOrderNo);
            RequestValidator.ValidateMaxLength("merchant_order_no", this.MerchantOrderNo, 32);
            RequestValidator.ValidateRequired("order_type", this.OrderType);
            RequestValidator.ValidateMaxLength("order_type", this.OrderType, 10);
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
