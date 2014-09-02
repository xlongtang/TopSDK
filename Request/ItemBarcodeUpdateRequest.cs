using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.barcode.update
    /// </summary>
    public class ItemBarcodeUpdateRequest : ITopRequest<ItemBarcodeUpdateResponse>
    {
        /// <summary>
        /// 商品条形码，如果不用更新，可选择不填
        /// </summary>
        public string ItemBarcode { get; set; }

        /// <summary>
        /// 被更新商品的ID
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// SKU维度的条形码，和sku_ids字段一一对应，中间以英文逗号分隔
        /// </summary>
        public string SkuBarcodes { get; set; }

        /// <summary>
        /// 被更新SKU的ID列表，中间以英文逗号进行分隔。如果没有SKU或者不需要更新SKU的条形码，不需要设置
        /// </summary>
        public string SkuIds { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.barcode.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_barcode", this.ItemBarcode);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("sku_barcodes", this.SkuBarcodes);
            parameters.Add("sku_ids", this.SkuIds);
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
