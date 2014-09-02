using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.cspu.move
    /// </summary>
    public class ItemCspuMoveRequest : ITopRequest<ItemCspuMoveResponse>
    {
        /// <summary>
        /// 商品id，必填
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 如果商品存在sku信息，必须输入sku和cspu的映射关系，可以支持多个skuID对应一个cspuID。“-1”代替删除sku。反之不能填写
        /// </summary>
        public string SkuCspuMapping { get; set; }

        /// <summary>
        /// 商品有SKU信息并且类目配置了营销属性（如套餐），则必须填写sku和套餐的映射关系。并且sku套餐信息和sku_cspu_mapping传入的sku_id信息保持一致。反之，不需要填写，
        /// </summary>
        public string SkuMealpropertyMapping { get; set; }

        /// <summary>
        /// 商品需要挂接的目产品ID，如果不填默认不修改产品ID,即商品本身对应的产品ID
        /// </summary>
        public Nullable<long> SpuId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.cspu.move";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_id", this.ItemId);
            parameters.Add("sku_cspu_mapping", this.SkuCspuMapping);
            parameters.Add("sku_mealproperty_mapping", this.SkuMealpropertyMapping);
            parameters.Add("spu_id", this.SpuId);
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
