using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alipay.micropay.order.freeze
    /// </summary>
    public class AlipayMicropayOrderFreezeRequest : ITopRequest<AlipayMicropayOrderFreezeResponse>
    {
        /// <summary>
        /// 需要冻结金额，[0.01,2000]，必须是正数，最多只能保留小数点两位,单位是元
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝用户给应用的授权.
        /// </summary>
        public string AuthToken { get; set; }

        /// <summary>
        /// 冻结资金的到期时间，超过此日期，冻结金会自动解冻,时间要求是:[当前时间+24h,订购时间-8h] .
        /// </summary>
        public Nullable<DateTime> ExpireTime { get; set; }

        /// <summary>
        /// 冻结备注,maxLength=40
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 商户订单号,只能由字母和数字组成，最大长度32.此外部订单号与支付宝的冻结订单号对应,注意 应用id和订购者id和外部订单号必须保证唯一性。
        /// </summary>
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 在解冻转账的时候的支付方式:  NO_CONFIRM：不需要付款确认，调用接口直接扣款  PAY_PASSWORD:  在转账需要付款方用支付密码确认，才可以转账成功
        /// </summary>
        public string PayConfirm { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alipay.micropay.order.freeze";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("amount", this.Amount);
            parameters.Add("auth_token", this.AuthToken);
            parameters.Add("expire_time", this.ExpireTime);
            parameters.Add("memo", this.Memo);
            parameters.Add("merchant_order_no", this.MerchantOrderNo);
            parameters.Add("pay_confirm", this.PayConfirm);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("amount", this.Amount);
            RequestValidator.ValidateRequired("expire_time", this.ExpireTime);
            RequestValidator.ValidateRequired("memo", this.Memo);
            RequestValidator.ValidateRequired("merchant_order_no", this.MerchantOrderNo);
            RequestValidator.ValidateRequired("pay_confirm", this.PayConfirm);
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
