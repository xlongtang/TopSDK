using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.sku.add
    /// </summary>
    public class ItemSkuAddRequest : ITopRequest<ItemSkuAddResponse>
    {
        /// <summary>
        /// 忽略警告提示.
        /// </summary>
        public string Ignorewarning { get; set; }

        /// <summary>
        /// sku所属商品的价格。当用户新增sku，使商品价格不属于sku价格之间的时候，用于修改商品的价格，使sku能够添加成功
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
        /// Sku的商家外部id
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// Sku的销售价格。商品的价格要在商品所有的sku的价格之间。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// Sku属性串。格式:pid:vid;pid:vid,如:1627207:3232483;1630696:3284570,表示:机身颜色:军绿色;手机套餐:一电一充。  如果包含自定义属性则格式为pid:vid;pid2:vid2;$pText:vText , 其中$pText:vText为自定义属性。限制：其中$pText的‘$’前缀不能少，且pText和vText文本中不可以存在 冒号:和分号;以及逗号，
        /// </summary>
        public string Properties { get; set; }

        /// <summary>
        /// Sku的库存数量。sku的总数量应该小于等于商品总数量(Item的NUM)。取值范围:大于零的整数
        /// </summary>
        public Nullable<long> Quantity { get; set; }

        /// <summary>
        /// 家装建材类目，商品SKU的高度，单位为cm，部分类目必选。天猫商家专用。  可选值为："0-15", "15-25", "25-50", "50-60", "60-80", "80-120", "120-160", "160-200"。  数据和SKU一一对应，用,分隔，如：15-25,25-50,25-50
        /// </summary>
        public string SkuHdHeight { get; set; }

        /// <summary>
        /// 家装建材类目，商品SKU的灯头数量，正整数，大于等于3，部分类目必选。天猫商家专用。  数据和SKU一一对应，用,分隔，如：3,5,7
        /// </summary>
        public string SkuHdLampQuantity { get; set; }

        /// <summary>
        /// 家装建材类目，商品SKU的长度，正整数，单位为cm，部分类目必选。天猫商家专用。  数据和SKU一一对应，用,分隔，如：20,30,30
        /// </summary>
        public string SkuHdLength { get; set; }

        /// <summary>
        /// 产品的规格信息
        /// </summary>
        public string SpecId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.sku.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("ignorewarning", this.Ignorewarning);
            parameters.Add("item_price", this.ItemPrice);
            parameters.Add("lang", this.Lang);
            parameters.Add("num_iid", this.NumIid);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("price", this.Price);
            parameters.Add("properties", this.Properties);
            parameters.Add("quantity", this.Quantity);
            parameters.Add("sku_hd_height", this.SkuHdHeight);
            parameters.Add("sku_hd_lamp_quantity", this.SkuHdLampQuantity);
            parameters.Add("sku_hd_length", this.SkuHdLength);
            parameters.Add("spec_id", this.SpecId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("num_iid", this.NumIid);
            RequestValidator.ValidateMinValue("num_iid", this.NumIid, 0);
            RequestValidator.ValidateRequired("price", this.Price);
            RequestValidator.ValidateRequired("properties", this.Properties);
            RequestValidator.ValidateRequired("quantity", this.Quantity);
            RequestValidator.ValidateMinValue("quantity", this.Quantity, 0);
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
