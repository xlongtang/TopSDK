using System;
using Top.Api.Domain;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.waybill.i.print
    /// </summary>
    public class WlbWaybillIPrintRequest : ITopRequest<WlbWaybillIPrintResponse>
    {
        /// <summary>
        /// 打印请求
        /// </summary>
        public string WaybillApplyPrintCheckRequest { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.waybill.i.print";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("waybill_apply_print_check_request", this.WaybillApplyPrintCheckRequest);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("waybill_apply_print_check_request", this.WaybillApplyPrintCheckRequest);
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
