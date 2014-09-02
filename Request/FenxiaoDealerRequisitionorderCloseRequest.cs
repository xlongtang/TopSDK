using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.dealer.requisitionorder.close
    /// </summary>
    public class FenxiaoDealerRequisitionorderCloseRequest : ITopRequest<FenxiaoDealerRequisitionorderCloseResponse>
    {
        /// <summary>
        /// 经销采购单编号
        /// </summary>
        public Nullable<long> DealerOrderId { get; set; }

        /// <summary>
        /// 关闭原因：  1：长时间无法联系到分销商，取消交易。  2：分销商错误提交申请，取消交易。  3：缺货，近段时间都无法发货。  4：分销商恶意提交申请单。  5：其他原因。
        /// </summary>
        public Nullable<long> Reason { get; set; }

        /// <summary>
        /// 关闭详细原因，字数5-200字
        /// </summary>
        public string ReasonDetail { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.dealer.requisitionorder.close";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("dealer_order_id", this.DealerOrderId);
            parameters.Add("reason", this.Reason);
            parameters.Add("reason_detail", this.ReasonDetail);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("dealer_order_id", this.DealerOrderId);
            RequestValidator.ValidateRequired("reason", this.Reason);
            RequestValidator.ValidateRequired("reason_detail", this.ReasonDetail);
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
