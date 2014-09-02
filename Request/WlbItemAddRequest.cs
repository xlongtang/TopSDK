using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.item.add
    /// </summary>
    public class WlbItemAddRequest : ITopRequest<WlbItemAddResponse>
    {
        /// <summary>
        /// 商品颜色
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// 货类
        /// </summary>
        public string GoodsCat { get; set; }

        /// <summary>
        /// 商品高度，单位毫米
        /// </summary>
        public Nullable<long> Height { get; set; }

        /// <summary>
        /// 是否危险品
        /// </summary>
        public Nullable<bool> IsDangerous { get; set; }

        /// <summary>
        /// 是否易碎品
        /// </summary>
        public Nullable<bool> IsFriable { get; set; }

        /// <summary>
        /// 是否sku
        /// </summary>
        public string IsSku { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品长度，单位毫米
        /// </summary>
        public Nullable<long> Length { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 商品包装材料类型
        /// </summary>
        public string PackageMaterial { get; set; }

        /// <summary>
        /// 商品价格，单位：分
        /// </summary>
        public Nullable<long> Price { get; set; }

        /// <summary>
        /// 计价货类
        /// </summary>
        public string PricingCat { get; set; }

        /// <summary>
        /// 属性名列表,目前支持的属性：  毛重:GWeight   净重:Nweight  皮重: Tweight  自定义属性：  paramkey1  paramkey2  paramkey3  paramkey4
        /// </summary>
        public string ProNameList { get; set; }

        /// <summary>
        /// 属性值列表：  10,8
        /// </summary>
        public string ProValueList { get; set; }

        /// <summary>
        /// 商品备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 是否支持批次
        /// </summary>
        public Nullable<bool> SupportBatch { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// NORMAL--普通商品  COMBINE--组合商品  DISTRIBUTION--分销
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 商品体积，单位立方厘米
        /// </summary>
        public Nullable<long> Volume { get; set; }

        /// <summary>
        /// 商品重量，单位G
        /// </summary>
        public Nullable<long> Weight { get; set; }

        /// <summary>
        /// 商品宽度，单位毫米
        /// </summary>
        public Nullable<long> Width { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.item.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("color", this.Color);
            parameters.Add("goods_cat", this.GoodsCat);
            parameters.Add("height", this.Height);
            parameters.Add("is_dangerous", this.IsDangerous);
            parameters.Add("is_friable", this.IsFriable);
            parameters.Add("is_sku", this.IsSku);
            parameters.Add("item_code", this.ItemCode);
            parameters.Add("length", this.Length);
            parameters.Add("name", this.Name);
            parameters.Add("package_material", this.PackageMaterial);
            parameters.Add("price", this.Price);
            parameters.Add("pricing_cat", this.PricingCat);
            parameters.Add("pro_name_list", this.ProNameList);
            parameters.Add("pro_value_list", this.ProValueList);
            parameters.Add("remark", this.Remark);
            parameters.Add("support_batch", this.SupportBatch);
            parameters.Add("title", this.Title);
            parameters.Add("type", this.Type);
            parameters.Add("volume", this.Volume);
            parameters.Add("weight", this.Weight);
            parameters.Add("width", this.Width);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("is_sku", this.IsSku);
            RequestValidator.ValidateRequired("item_code", this.ItemCode);
            RequestValidator.ValidateRequired("name", this.Name);
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
