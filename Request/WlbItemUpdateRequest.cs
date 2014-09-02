using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.wlb.item.update
    /// </summary>
    public class WlbItemUpdateRequest : ITopRequest<WlbItemUpdateResponse>
    {
        /// <summary>
        /// 商品颜色
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// 需要删除的商品属性key列表
        /// </summary>
        public string DeletePropertyKeyList { get; set; }

        /// <summary>
        /// 商品货类
        /// </summary>
        public string GoodsCat { get; set; }

        /// <summary>
        /// 商品高度，单位厘米
        /// </summary>
        public Nullable<long> Height { get; set; }

        /// <summary>
        /// 要修改的商品id
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 是否危险品
        /// </summary>
        public Nullable<bool> IsDangerous { get; set; }

        /// <summary>
        /// 是否易碎品
        /// </summary>
        public Nullable<bool> IsFriable { get; set; }

        /// <summary>
        /// 商品长度，单位厘米
        /// </summary>
        public Nullable<long> Length { get; set; }

        /// <summary>
        /// 要修改的商品名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 商品包装材料类型
        /// </summary>
        public string PackageMaterial { get; set; }

        /// <summary>
        /// 商品计价货类
        /// </summary>
        public string PricingCat { get; set; }

        /// <summary>
        /// 要修改的商品备注
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// 要修改的商品标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 需要修改的商品属性值的列表，如果属性不存在，则新增属性
        /// </summary>
        public string UpdatePropertyKeyList { get; set; }

        /// <summary>
        /// 需要修改的属性值的列表
        /// </summary>
        public string UpdatePropertyValueList { get; set; }

        /// <summary>
        /// 商品体积，单位立方厘米
        /// </summary>
        public Nullable<long> Volume { get; set; }

        /// <summary>
        /// 商品重量，单位G
        /// </summary>
        public Nullable<long> Weight { get; set; }

        /// <summary>
        /// 商品宽度，单位厘米
        /// </summary>
        public Nullable<long> Width { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.wlb.item.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("color", this.Color);
            parameters.Add("delete_property_key_list", this.DeletePropertyKeyList);
            parameters.Add("goods_cat", this.GoodsCat);
            parameters.Add("height", this.Height);
            parameters.Add("id", this.Id);
            parameters.Add("is_dangerous", this.IsDangerous);
            parameters.Add("is_friable", this.IsFriable);
            parameters.Add("length", this.Length);
            parameters.Add("name", this.Name);
            parameters.Add("package_material", this.PackageMaterial);
            parameters.Add("pricing_cat", this.PricingCat);
            parameters.Add("remark", this.Remark);
            parameters.Add("title", this.Title);
            parameters.Add("update_property_key_list", this.UpdatePropertyKeyList);
            parameters.Add("update_property_value_list", this.UpdatePropertyValueList);
            parameters.Add("volume", this.Volume);
            parameters.Add("weight", this.Weight);
            parameters.Add("width", this.Width);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("id", this.Id);
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
