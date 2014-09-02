using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.product.gradeprice.get
    /// </summary>
    public class FenxiaoProductGradepriceGetRequest : ITopRequest<FenxiaoProductGradepriceGetResponse>
    {
        /// <summary>
        /// 产品id
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// skuId
        /// </summary>
        public Nullable<long> SkuId { get; set; }

        /// <summary>
        /// 经、代销模式（1：代销、2：经销）
        /// </summary>
        public Nullable<long> TradeType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.product.gradeprice.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("product_id", this.ProductId);
            parameters.Add("sku_id", this.SkuId);
            parameters.Add("trade_type", this.TradeType);
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
