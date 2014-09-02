using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.eai.order.refund.good.return.agree
    /// </summary>
    public class TmallEaiOrderRefundGoodReturnAgreeRequest : ITopRequest<TmallEaiOrderRefundGoodReturnAgreeResponse>
    {
        /// <summary>
        /// 同意退货留言
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 退款单编号
        /// </summary>
        public Nullable<long> RefundId { get; set; }

        /// <summary>
        /// 售中：onsale  售后：aftersale
        /// </summary>
        public string RefundPhase { get; set; }

        /// <summary>
        /// 退款版本号
        /// </summary>
        public Nullable<long> RefundVersion { get; set; }

        /// <summary>
        /// 卖家收货地址编号
        /// </summary>
        public Nullable<long> SellerLogisticsAddressId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.eai.order.refund.good.return.agree";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("message", this.Message);
            parameters.Add("refund_id", this.RefundId);
            parameters.Add("refund_phase", this.RefundPhase);
            parameters.Add("refund_version", this.RefundVersion);
            parameters.Add("seller_logistics_address_id", this.SellerLogisticsAddressId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("message", this.Message);
            RequestValidator.ValidateRequired("refund_id", this.RefundId);
            RequestValidator.ValidateRequired("refund_phase", this.RefundPhase);
            RequestValidator.ValidateRequired("refund_version", this.RefundVersion);
            RequestValidator.ValidateRequired("seller_logistics_address_id", this.SellerLogisticsAddressId);
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
