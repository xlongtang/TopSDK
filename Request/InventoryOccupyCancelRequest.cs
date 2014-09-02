using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.inventory.occupy.cancel
    /// </summary>
    public class InventoryOccupyCancelRequest : ITopRequest<InventoryOccupyCancelResponse>
    {
        /// <summary>
        /// 商家外部定单号
        /// </summary>
        public string BizUniqueCode { get; set; }

        /// <summary>
        /// 申请预留时的操作返回码
        /// </summary>
        public string OperateCode { get; set; }

        /// <summary>
        /// 商家仓库编码
        /// </summary>
        public string StoreCode { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.inventory.occupy.cancel";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("biz_unique_code", this.BizUniqueCode);
            parameters.Add("operate_code", this.OperateCode);
            parameters.Add("store_code", this.StoreCode);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("biz_unique_code", this.BizUniqueCode);
            RequestValidator.ValidateRequired("operate_code", this.OperateCode);
            RequestValidator.ValidateRequired("store_code", this.StoreCode);
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
