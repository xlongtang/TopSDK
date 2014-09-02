using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.eai.order.refund.billsum.get
    /// </summary>
    public class TmallEaiOrderRefundBillsumGetRequest : ITopRequest<TmallEaiOrderRefundBillsumGetResponse>
    {
        /// <summary>
        /// 查找数量的单据类型 refund_bill:退款单， return_bill:退货单
        /// </summary>
        public string BillType { get; set; }

        /// <summary>
        /// 批量查询结束时间
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 批量查询开始时间
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        /// <summary>
        /// 退货单 退款单状态
        /// </summary>
        public string Status { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.eai.order.refund.billsum.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("bill_type", this.BillType);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("start_time", this.StartTime);
            parameters.Add("status", this.Status);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("bill_type", this.BillType);
            RequestValidator.ValidateRequired("end_time", this.EndTime);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
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
