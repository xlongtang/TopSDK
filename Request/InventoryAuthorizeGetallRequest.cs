using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.inventory.authorize.getall
    /// </summary>
    public class InventoryAuthorizeGetallRequest : ITopRequest<InventoryAuthorizeGetallResponse>
    {
        /// <summary>
        /// 商品编码列表，使用”,”分割多个号码，最大50个
        /// </summary>
        public string ScItemIdList { get; set; }

        /// <summary>
        /// 指定的商家仓库编码，使用”,”分割多个仓库
        /// </summary>
        public string StoreCodeList { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.inventory.authorize.getall";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("sc_item_id_list", this.ScItemIdList);
            parameters.Add("store_code_list", this.StoreCodeList);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("sc_item_id_list", this.ScItemIdList);
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
