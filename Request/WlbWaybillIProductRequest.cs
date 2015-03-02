using System;
using Top.Api.Domain;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.waybill.i.product
    /// </summary>
    public class WlbWaybillIProductRequest : ITopRequest<WlbWaybillIProductResponse>
    {
        /// <summary>
        /// 查询物流商电子面单产品类型入参
        /// </summary>
        public string WaybillProductTypeRequest { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.waybill.i.product";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("waybill_product_type_request", this.WaybillProductTypeRequest);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("waybill_product_type_request", this.WaybillProductTypeRequest);
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
