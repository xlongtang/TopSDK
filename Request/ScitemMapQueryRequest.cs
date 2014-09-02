using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.scitem.map.query
    /// </summary>
    public class ScitemMapQueryRequest : ITopRequest<ScitemMapQueryResponse>
    {
        /// <summary>
        /// map_type为1：前台ic商品id  map_type为2：分销productid
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// map_type为1：前台ic商品skuid   map_type为2：分销商品的skuid
        /// </summary>
        public Nullable<long> SkuId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.scitem.map.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_id", this.ItemId);
            parameters.Add("sku_id", this.SkuId);
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
