using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.inventory.query
    /// </summary>
    public class InventoryQueryRequest : ITopRequest<InventoryQueryResponse>
    {
        /// <summary>
        /// 后端商品的商家编码列表，控制到50个
        /// </summary>
        public string ScItemCodes { get; set; }

        /// <summary>
        /// 后端商品ID 列表，控制到50个
        /// </summary>
        public string ScItemIds { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        public string SellerNick { get; set; }

        /// <summary>
        /// 仓库列表:GLY001^GLY002
        /// </summary>
        public string StoreCodes { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.inventory.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("sc_item_codes", this.ScItemCodes);
            parameters.Add("sc_item_ids", this.ScItemIds);
            parameters.Add("seller_nick", this.SellerNick);
            parameters.Add("store_codes", this.StoreCodes);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("sc_item_ids", this.ScItemIds);
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
