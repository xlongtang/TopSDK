using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fenxiao.product.map.add
    /// </summary>
    public class FenxiaoProductMapAddRequest : ITopRequest<FenxiaoProductMapAddResponse>
    {
        /// <summary>
        /// 是否需要校验商家编码，true不校验，false校验。
        /// </summary>
        public Nullable<bool> NotCheckOuterCode { get; set; }

        /// <summary>
        /// 分销产品id。
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// 后端商品id（如果当前分销产品没有sku和后端商品时需要指定）。
        /// </summary>
        public Nullable<long> ScItemId { get; set; }

        /// <summary>
        /// 在有sku的情况下，与各个sku对应的后端商品id列表。逗号分隔，顺序需要保证与sku_ids一致。
        /// </summary>
        public string ScItemIds { get; set; }

        /// <summary>
        /// 分销产品的sku id。逗号分隔，顺序需要保证与sc_item_ids一致（没有sku就不传）。
        /// </summary>
        public string SkuIds { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fenxiao.product.map.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("not_check_outer_code", this.NotCheckOuterCode);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("sc_item_id", this.ScItemId);
            parameters.Add("sc_item_ids", this.ScItemIds);
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
