using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.brandcat.metadata.get
    /// </summary>
    public class TmallBrandcatMetadataGetRequest : ITopRequest<TmallBrandcatMetadataGetResponse>
    {
        /// <summary>
        /// 品牌id
        /// </summary>
        public Nullable<long> BrandId { get; set; }

        /// <summary>
        /// 叶子类目id
        /// </summary>
        public Nullable<long> CatId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.brandcat.metadata.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("brand_id", this.BrandId);
            parameters.Add("cat_id", this.CatId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("cat_id", this.CatId);
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
