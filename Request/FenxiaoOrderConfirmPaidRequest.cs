using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.order.confirm.paid
    /// </summary>
    public class FenxiaoOrderConfirmPaidRequest : ITopRequest<FenxiaoOrderConfirmPaidResponse>
    {
        /// <summary>
        /// 确认支付信息（字数小于100）
        /// </summary>
        public string ConfirmRemark { get; set; }

        /// <summary>
        /// 采购单编号。
        /// </summary>
        public Nullable<long> PurchaseOrderId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.order.confirm.paid";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("confirm_remark", this.ConfirmRemark);
            parameters.Add("purchase_order_id", this.PurchaseOrderId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("purchase_order_id", this.PurchaseOrderId);
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
