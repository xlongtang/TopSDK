using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.product.sku.update
    /// </summary>
    public class FenxiaoProductSkuUpdateRequest : ITopRequest<FenxiaoProductSkuUpdateResponse>
    {
        /// <summary>
        /// 代销采购价
        /// </summary>
        public string AgentCostPrice { get; set; }

        /// <summary>
        /// 经销采购价
        /// </summary>
        public string DealerCostPrice { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// sku属性
        /// </summary>
        public string Properties { get; set; }

        /// <summary>
        /// 产品SKU库存
        /// </summary>
        public Nullable<long> Quantity { get; set; }

        /// <summary>
        /// 商家编码
        /// </summary>
        public string SkuNumber { get; set; }

        /// <summary>
        /// 采购基准价
        /// </summary>
        public string StandardPrice { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.product.sku.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("agent_cost_price", this.AgentCostPrice);
            parameters.Add("dealer_cost_price", this.DealerCostPrice);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("properties", this.Properties);
            parameters.Add("quantity", this.Quantity);
            parameters.Add("sku_number", this.SkuNumber);
            parameters.Add("standard_price", this.StandardPrice);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("product_id", this.ProductId);
            RequestValidator.ValidateRequired("properties", this.Properties);
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
