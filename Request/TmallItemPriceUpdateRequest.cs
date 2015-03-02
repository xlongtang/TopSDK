using System;
using Top.Api.Domain;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.item.price.update
    /// </summary>
    public class TmallItemPriceUpdateRequest : ITopRequest<TmallItemPriceUpdateResponse>
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 被更新商品价格
        /// </summary>
        public string ItemPrice { get; set; }

        /// <summary>
        /// 商品价格更新时候的可选参数
        /// </summary>
        public string Options { get; set; }

        /// <summary>
        /// 更新SKU价格时候的SKU价格对象；如果没有SKU或者不更新SKU价格，可以不填;查找SKU目前支持ID，属性串和商家编码三种模式，建议选用一种最合适的，切勿滥用，一次调用中如果混合使用，更新结果不可预期！
        /// </summary>
        public string SkuPrices { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.item.price.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_id", this.ItemId);
            parameters.Add("item_price", this.ItemPrice);
            parameters.Add("options", this.Options);
            parameters.Add("sku_prices", this.SkuPrices);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateMaxListSize("sku_prices", this.SkuPrices, 999999);
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
