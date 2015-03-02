using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.item.update.schema.get
    /// </summary>
    public class TmallItemUpdateSchemaGetRequest : ITopRequest<TmallItemUpdateSchemaGetResponse>
    {
        /// <summary>
        /// 商品发布的目标类目，必须是叶子类目。如果没有切换类目需求，不需要填写。
        /// </summary>
        public Nullable<long> CategoryId { get; set; }

        /// <summary>
        /// 需要编辑的商品ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 商品发布的目标product_id。如果没有切换产品的需求，参数可以不填写。
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.item.update.schema.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("category_id", this.CategoryId);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("product_id", this.ProductId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("item_id", this.ItemId);
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
