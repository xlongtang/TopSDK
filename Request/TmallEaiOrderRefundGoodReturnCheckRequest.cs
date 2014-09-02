using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.eai.order.refund.good.return.check
    /// </summary>
    public class TmallEaiOrderRefundGoodReturnCheckRequest : ITopRequest<TmallEaiOrderRefundGoodReturnCheckResponse>
    {
        /// <summary>
        /// 物流公司编号
        /// </summary>
        public string CompanyCode { get; set; }

        /// <summary>
        /// 1.验货通过  2.验货不通过
        /// </summary>
        public Nullable<long> ConfirmResult { get; set; }

        /// <summary>
        /// 验货时间
        /// </summary>
        public Nullable<DateTime> ConfirmTime { get; set; }

        /// <summary>
        /// 验货人员
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// 退款单编号
        /// </summary>
        public Nullable<long> RefundId { get; set; }

        /// <summary>
        /// 售中：onsale  售后：aftersale
        /// </summary>
        public string RefundPhase { get; set; }

        /// <summary>
        /// 物流运单号
        /// </summary>
        public string Sid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.eai.order.refund.good.return.check";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("company_code", this.CompanyCode);
            parameters.Add("confirm_result", this.ConfirmResult);
            parameters.Add("confirm_time", this.ConfirmTime);
            parameters.Add("operator", this.Operator);
            parameters.Add("refund_id", this.RefundId);
            parameters.Add("refund_phase", this.RefundPhase);
            parameters.Add("sid", this.Sid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("company_code", this.CompanyCode);
            RequestValidator.ValidateRequired("confirm_result", this.ConfirmResult);
            RequestValidator.ValidateRequired("confirm_time", this.ConfirmTime);
            RequestValidator.ValidateRequired("refund_id", this.RefundId);
            RequestValidator.ValidateRequired("refund_phase", this.RefundPhase);
            RequestValidator.ValidateRequired("sid", this.Sid);
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
