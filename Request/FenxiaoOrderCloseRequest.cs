using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.order.close
    /// </summary>
    public class FenxiaoOrderCloseRequest : ITopRequest<FenxiaoOrderCloseResponse>
    {
        /// <summary>
        /// 关闭理由,特殊字符会被转义，会改变长度，有特殊字符是请注意
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 采购单编号
        /// </summary>
        public Nullable<long> PurchaseOrderId { get; set; }

        /// <summary>
        /// 子采购单ID，可传多笔子单ID，逗号分隔
        /// </summary>
        public string SubOrderIds { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.order.close";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("message", this.Message);
            parameters.Add("purchase_order_id", this.PurchaseOrderId);
            parameters.Add("sub_order_ids", this.SubOrderIds);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("message", this.Message);
            RequestValidator.ValidateMaxLength("message", this.Message, 200);
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
