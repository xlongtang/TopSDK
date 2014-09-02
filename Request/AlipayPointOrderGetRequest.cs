using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alipay.point.order.get
    /// </summary>
    public class AlipayPointOrderGetRequest : ITopRequest<AlipayPointOrderGetResponse>
    {
        /// <summary>
        /// 支付宝用户给应用的授权。
        /// </summary>
        public string AuthToken { get; set; }

        /// <summary>
        /// isv提供的发放号订单号，由数字和组成，最大长度为32为，需要保证每笔发放的唯一性，支付宝会对该参数做唯一性控制。如果使用同样的订单号，支付宝将返回订单号已经存在的错误
        /// </summary>
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 用户标识符，用于指定集分宝发放的用户，和user_symbol_type一起使用，确定一个唯一的支付宝用户
        /// </summary>
        public string UserSymbol { get; set; }

        /// <summary>
        /// 用户标识符类型，现在支持ALIPAY_USER_ID:表示支付宝用户ID,ALIPAY_LOGON_ID:表示支付宝登陆号
        /// </summary>
        public string UserSymbolType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alipay.point.order.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auth_token", this.AuthToken);
            parameters.Add("merchant_order_no", this.MerchantOrderNo);
            parameters.Add("user_symbol", this.UserSymbol);
            parameters.Add("user_symbol_type", this.UserSymbolType);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("merchant_order_no", this.MerchantOrderNo);
            RequestValidator.ValidateRequired("user_symbol", this.UserSymbol);
            RequestValidator.ValidateRequired("user_symbol_type", this.UserSymbolType);
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
