using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alipay.ebpp.bill.get
    /// </summary>
    public class AlipayEbppBillGetRequest : ITopRequest<AlipayEbppBillGetResponse>
    {
        /// <summary>
        /// 支付宝授权凭证，如果有淘宝的session可以不传
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
            return "alipay.ebpp.bill.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auth_token", this.AuthToken);
            parameters.Add("merchant_order_no", this.MerchantOrderNo);
            parameters.Add("order_type", this.OrderType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
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
