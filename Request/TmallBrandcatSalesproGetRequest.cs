using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.brandcat.salespro.get
    /// </summary>
    public class TmallBrandcatSalesproGetRequest : ITopRequest<TmallBrandcatSalesproGetResponse>
    {
        /// <summary>
        /// 被管控的品牌Id
        /// </summary>
        public Nullable<long> BrandId { get; set; }

        /// <summary>
        /// 被管控的类目Id
        /// </summary>
        public Nullable<long> CatId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.brandcat.salespro.get";
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
            RequestValidator.ValidateRequired("brand_id", this.BrandId);
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
