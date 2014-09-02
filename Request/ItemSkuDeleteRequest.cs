using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.sku.delete
    /// </summary>
    public class ItemSkuDeleteRequest : ITopRequest<ItemSkuDeleteResponse>
    {
        /// <summary>
        /// sku所属商品的数量,大于0的整数。当用户删除sku，使商品数量不等于sku数量之和时候，用于修改商品的数量，使sku能够删除成功。特别是删除最后一个sku的时候，一定要设置商品数量到正常的值，否则删除失败
        /// </summary>
        public Nullable<long> ItemNum { get; set; }

        /// <summary>
        /// sku所属商品的价格。当用户删除sku，使商品价格不属于sku价格之间的时候，用于修改商品的价格，使sku能够删除成功
        /// </summary>
        public string ItemPrice { get; set; }

        /// <summary>
        /// Sku文字的版本。可选值:zh_HK(繁体),zh_CN(简体);默认值:zh_CN
        /// </summary>
        public string Lang { get; set; }

        /// <summary>
        /// Sku所属商品数字id，可通过 taobao.item.get 获取。必选
        /// </summary>
        public Nullable<long> NumIid { get; set; }

        /// <summary>
        /// Sku属性串。格式:pid:vid;pid:vid,如: 1627207:3232483;1630696:3284570,表示机身颜色:军绿色;手机套餐:一电一充
        /// </summary>
        public string Properties { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.sku.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_num", this.ItemNum);
            parameters.Add("item_price", this.ItemPrice);
            parameters.Add("lang", this.Lang);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("properties", this.Properties);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("num_iid", this.NumIid);
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
