using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.product.map.delete
    /// </summary>
    public class FenxiaoProductMapDeleteRequest : ITopRequest<FenxiaoProductMapDeleteResponse>
    {
        /// <summary>
        /// 分销产品id。
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// 分销产品的sku id列表，逗号分隔，在有sku时需要指定。
        /// </summary>
        public string SkuIds { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.product.map.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("product_id", this.ProductId);
            parameters.Add("sku_ids", this.SkuIds);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("product_id", this.ProductId);
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
