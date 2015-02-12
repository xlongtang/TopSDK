using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.product.update
    /// </summary>
    public class ProductUpdateRequest : ITopUploadRequest<ProductUpdateResponse>
    {
        /// <summary>
        /// 非关键属性.调用taobao.itemprops.get获取pid,调用taobao.itempropvalues.get获取vid;格式:pid:vid;pid:vid
        /// </summary>
        public string Binds { get; set; }

        /// <summary>
        /// 产品描述.最大不超过25000个字符
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 存放产品扩展信息，由List(ProductExtraInfo)转化成jsonArray存入.
        /// </summary>
        public string ExtraInfo { get; set; }

        /// <summary>
        /// 产品主图.最大500K,目前仅支持GIF,JPG
        /// </summary>
        public FileItem Image { get; set; }

        /// <summary>
        /// 是否是主图
        /// </summary>
        public Nullable<bool> Major { get; set; }

        /// <summary>
        /// 市场ID，1为更新C2C市场的产品信息， 2为更新B2C市场的产品信息。  不填写此值则C用户更新B2C市场的产品信息，B用户更新B2C市场的产品信息。
        /// </summary>
        public string MarketId { get; set; }

        /// <summary>
        /// 产品名称.最大不超过30个字符
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 自定义非关键属性
        /// </summary>
        public string NativeUnkeyprops { get; set; }

        /// <summary>
        /// 外部产品ID
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 保证清单。
        /// </summary>
        public string PackingList { get; set; }

        /// <summary>
        /// 产品市场价.精确到2位小数;单位为元.如:200.07
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        public Nullable<long> ProductId { get; set; }

        /// <summary>
        /// 销售属性.调用taobao.itemprops.get获取pid,调用taobao.itempropvalues.get获取vid;格式:pid:vid;pid:vid
        /// </summary>
        public string SaleProps { get; set; }

        /// <summary>
        /// 产品卖点描述，最长40个字节
        /// </summary>
        public string SellPt { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.product.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("binds", this.Binds);
            parameters.Add("desc", this.Desc);
            parameters.Add("extra_info", this.ExtraInfo);
            parameters.Add("major", this.Major);
            parameters.Add("market_id", this.MarketId);
            parameters.Add("name", this.Name);
            parameters.Add("native_unkeyprops", this.NativeUnkeyprops);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("packing_list", this.PackingList);
            parameters.Add("price", this.Price);
            parameters.Add("product_id", this.ProductId);
            parameters.Add("sale_props", this.SaleProps);
            parameters.Add("sell_pt", this.SellPt);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("extra_info", this.ExtraInfo, 25000);
            RequestValidator.ValidateMaxLength("image", this.Image, 1048576);
            RequestValidator.ValidateRequired("product_id", this.ProductId);
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
