using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.eai.order.refund.order.hold
    /// </summary>
    public class TmallEaiOrderRefundOrderHoldRequest : ITopRequest<TmallEaiOrderRefundOrderHoldResponse>
    {
        /// <summary>
        /// 1. 截停成功  2. 截停失败
        /// </summary>
        public Nullable<long> HoldResult { get; set; }

        /// <summary>
        /// 截停环节  1. 订单处理环节  2. 发货环节
        /// </summary>
        public Nullable<long> HoldStep { get; set; }

        /// <summary>
        /// 截单时间
        /// </summary>
        public Nullable<DateTime> HoldTime { get; set; }

        /// <summary>
        /// 退款单编号
        /// </summary>
        public Nullable<long> RefundId { get; set; }

        /// <summary>
        /// 售中：onsale  售后：aftersale
        /// </summary>
        public string RefundPhase { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.eai.order.refund.order.hold";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("hold_result", this.HoldResult);
            parameters.Add("hold_step", this.HoldStep);
            parameters.Add("hold_time", this.HoldTime);
            parameters.Add("refund_id", this.RefundId);
            parameters.Add("refund_phase", this.RefundPhase);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("hold_result", this.HoldResult);
            RequestValidator.ValidateRequired("hold_step", this.HoldStep);
            RequestValidator.ValidateRequired("hold_time", this.HoldTime);
            RequestValidator.ValidateRequired("refund_id", this.RefundId);
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
