using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.product.specs.get
    /// </summary>
    public class TmallProductSpecsGetRequest : ITopRequest<TmallProductSpecsGetResponse>
    {
        /// <summary>
        /// 类目的ID号，该id必须和properties同时传入。  而且只有当product_id不传入的时候才起效果。
        /// </summary>
        public Nullable<long> CatId { get; set; }

        /// <summary>
        /// 产品的ID。这个不能和properties和cat_id同时起效果
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// 关键属性的字符串，pid:vid;pid:vid  该字段必须和cat_id同时传入才起效果。 而且只有当product_id不传入的时候才起效果。
        /// </summary>
        public string Properties { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.product.specs.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("cat_id", this.CatId);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("properties", this.Properties);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
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
