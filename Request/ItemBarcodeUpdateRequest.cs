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
        /// 是否强制保存商品条码。  true：强制保存  false ：需要执行条码库校验
        /// </summary>
        public Nullable<bool> Isforce { get; set; }

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

        /// <summary>
        /// 访问来源，这字段提供给千牛扫码枪用，  其他调用方，不需要填写
        /// </summary>
        public string Src { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.barcode.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("isforce", this.Isforce);
            parameters.Add("item_barcode", this.ItemBarcode);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("sku_barcodes", this.SkuBarcodes);
            parameters.Add("sku_ids", this.SkuIds);
            parameters.Add("src", this.Src);
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
