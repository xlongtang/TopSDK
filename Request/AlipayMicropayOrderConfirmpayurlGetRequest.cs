using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: alipay.micropay.order.confirmpayurl.get
    /// </summary>
    public class AlipayMicropayOrderConfirmpayurlGetRequest : ITopRequest<AlipayMicropayOrderConfirmpayurlGetResponse>
    {
        /// <summary>
        /// 支付宝订单号，冻结流水号.这个是创建冻结订单支付宝返回的
        /// </summary>
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 支付金额,区间必须在[0.01,30]，只能保留小数点后两位
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝用户给应用的授权.
        /// </summary>
        public string AuthToken { get; set; }

        /// <summary>
        /// 支付备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 收款方的支付宝ID
        /// </summary>
        public string ReceiveUserId { get; set; }

        /// <summary>
        /// 本次转账的外部单据号（只能由字母和数字组成,maxlength=32）
        /// </summary>
        public string TransferOutOrderNo { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "alipay.micropay.order.confirmpayurl.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("alipay_order_no", this.AlipayOrderNo);
            parameters.Add("amount", this.Amount);
            parameters.Add("auth_token", this.AuthToken);
            parameters.Add("memo", this.Memo);
            parameters.Add("receive_user_id", this.ReceiveUserId);
            parameters.Add("transfer_out_order_no", this.TransferOutOrderNo);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("alipay_order_no", this.AlipayOrderNo);
            RequestValidator.ValidateRequired("amount", this.Amount);
            RequestValidator.ValidateRequired("memo", this.Memo);
            RequestValidator.ValidateRequired("receive_user_id", this.ReceiveUserId);
            RequestValidator.ValidateRequired("transfer_out_order_no", this.TransferOutOrderNo);
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
