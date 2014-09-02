using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.order.customfield.update
    /// </summary>
    public class FenxiaoOrderCustomfieldUpdateRequest : ITopRequest<FenxiaoOrderCustomfieldUpdateResponse>
    {
        /// <summary>
        /// 自定义key
        /// </summary>
        public string IsvCustomKey { get; set; }

        /// <summary>
        /// 自定义的值
        /// </summary>
        public string IsvCustomValue { get; set; }

        /// <summary>
        /// 采购单id
        /// </summary>
        public Nullable<long> PurchaseOrderId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.order.customfield.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("isv_custom_key", this.IsvCustomKey);
            parameters.Add("isv_custom_value", this.IsvCustomValue);
            parameters.Add("purchase_order_id", this.PurchaseOrderId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("isv_custom_key", this.IsvCustomKey);
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
