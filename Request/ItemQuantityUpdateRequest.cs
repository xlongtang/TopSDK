using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.quantity.update
    /// </summary>
    public class ItemQuantityUpdateRequest : ITopRequest<ItemQuantityUpdateResponse>
    {
        /// <summary>
        /// 商品数字ID，必填参数
        /// </summary>
        public Nullable<long> NumIid { get; set; }

        /// <summary>
        /// SKU的商家编码，可选参数。如果不填则默认修改宝贝的库存，如果填了则按照商家编码搜索出对应的SKU并修改库存。当sku_id和本字段都填写时以sku_id为准搜索对应SKU
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 库存修改值，必选。当全量更新库存时，quantity必须为大于等于0的正整数；当增量更新库存时，quantity为整数，可小于等于0。若增量更新时传入的库存为负数，则负数与实际库存之和不能小于0。比如当前实际库存为1，传入增量更新quantity=-1，库存改为0
        /// </summary>
        public Nullable<long> Quantity { get; set; }

        /// <summary>
        /// 要操作的SKU的数字ID，可选。如果不填默认修改宝贝的库存，如果填上则修改该SKU的库存
        /// </summary>
        public Nullable<long> SkuId { get; set; }

        /// <summary>
        /// 库存更新方式，可选。1为全量更新，2为增量更新。如果不填，默认为全量更新
        /// </summary>
        public Nullable<long> Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.quantity.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("quantity", this.Quantity);
            parameters.Add("sku_id", this.SkuId);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("num_iid", this.NumIid);
            RequestValidator.ValidateRequired("quantity", this.Quantity);
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
