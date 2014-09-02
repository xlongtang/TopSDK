using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.product.spec.add
    /// </summary>
    public class TmallProductSpecAddRequest : ITopUploadRequest<TmallProductSpecAddResponse>
    {
        /// <summary>
        /// 产品二维码
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        /// 存放产品规格认证类型-认证图片url映射信息，格式为k:v;k:v;，其中key为认证类型数字id，value为调用tmall.product.spec.pic.upload返回的认证图片url文本
        /// </summary>
        public string CertifiedPicStr { get; set; }

        /// <summary>
        /// 存放产品规格认证类型-认证文本映射信息，格式为k:v;k:v;，其中key为认证类型数字id，value为认证文本值
        /// </summary>
        public string CertifiedTxtStr { get; set; }

        /// <summary>
        /// 产品基础色，数据格式为：pid:vid:rvid1,rvid2,rvid3;pid:vid:rvid1
        /// </summary>
        public string ChangeProp { get; set; }

        /// <summary>
        /// 用户自定义销售属性，结构：pid1:value1;pid2:value2。在
        /// </summary>
        public string CustomerSpecProps { get; set; }

        /// <summary>
        /// 产品图片
        /// </summary>
        public FileItem Image { get; set; }

        /// <summary>
        /// 产品规格吊牌价，以分为单位，无默认值，上限999999999
        /// </summary>
        public Nullable<long> LabelPrice { get; set; }

        /// <summary>
        /// 产品上市时间
        /// </summary>
        public Nullable<DateTime> MarketTime { get; set; }

        /// <summary>
        /// 产品货号
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// 产品的规格属性
        /// </summary>
        public string SpecProps { get; set; }

        /// <summary>
        /// 规格属性别名,只允许传颜色别名
        /// </summary>
        public string SpecPropsAlias { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.product.spec.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("barcode", this.Barcode);
            parameters.Add("certified_pic_str", this.CertifiedPicStr);
            parameters.Add("certified_txt_str", this.CertifiedTxtStr);
            parameters.Add("change_prop", this.ChangeProp);
            parameters.Add("customer_spec_props", this.CustomerSpecProps);
            parameters.Add("label_price", this.LabelPrice);
            parameters.Add("market_time", this.MarketTime);
            parameters.Add("product_code", this.ProductCode);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("spec_props", this.SpecProps);
            parameters.Add("spec_props_alias", this.SpecPropsAlias);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("image", this.Image);
            RequestValidator.ValidateMaxValue("label_price", this.LabelPrice, 999999999);
            RequestValidator.ValidateMinValue("label_price", this.LabelPrice, 0);
            RequestValidator.ValidateRequired("product_id", this.ProductId);
            RequestValidator.ValidateMaxLength("spec_props_alias", this.SpecPropsAlias, 60);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("image", this.Image);
            return parameters;
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
