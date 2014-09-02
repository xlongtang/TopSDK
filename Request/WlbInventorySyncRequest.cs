using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.inventory.sync
    /// </summary>
    public class WlbInventorySyncRequest : ITopRequest<WlbInventorySyncResponse>
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 外部实体类型.存如下值   IC_ITEM --表示IC商品;   IC_SKU --表示IC最小单位商品;  WLB_ITEM  --表示WLB商品.  若值不在范围内，则按WLB_ITEM处理
        /// </summary>
        public string ItemType { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        public Nullable<long> Quantity { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.inventory.sync";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_id", this.ItemId);
            parameters.Add("item_type", this.ItemType);
            parameters.Add("quantity", this.Quantity);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateRequired("item_type", this.ItemType);
            RequestValidator.ValidateRequired("quantity", this.Quantity);
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
