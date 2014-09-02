using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.ebook.serial.update
    /// </summary>
    public class ItemEbookSerialUpdateRequest : ITopUploadRequest<ItemEbookSerialUpdateResponse>
    {
        /// <summary>
        /// 作者。长度不能超过60个字符<br /> 支持最大长度为：60<br /> 支持的最大列表长度为：60
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 叶子类目id<br /> 支持最小值为：0
        /// </summary>
        public Nullable<long> Cid { get; set; }

        /// <summary>
        /// 商品主图片。类型:JPG,PNG;最大:2M<br /> 支持的文件类型为：gif,jpg,jpeg,png<br /> 支持的最大列表长度为：524288
        /// </summary>
        public FileItem Cover { get; set; }

        /// <summary>
        /// 宝贝描述。字数要大于5个字符，小于25000个字符，受违禁词控制<br /> 支持最大长度为：200000<br /> 支持的最大列表长度为：200000
        /// </summary>
        public string Desc { get; set; }

        /// <summary>
        /// 宝贝数字id
        /// </summary>
        public Nullable<long> ItemId { get; set; }

        /// <summary>
        /// 书名。长度不能超过60个字符<br /> 支持最大长度为：60<br /> 支持的最大列表长度为：60
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 商品外部编码，该字段的最大长度是512个字节
        /// </summary>
        public string OuterId { get; set; }

        /// <summary>
        /// 不能为0；如：0.50元/章 或者 0.50元/千字；取值范围:0.01-9999.99;精确到2位小数;单位:元。如:5.07，表示:5元7分.
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 相关链接。不超过128个字符
        /// </summary>
        public string RelationLink { get; set; }

        /// <summary>
        /// 宝贝标题。不能超过60字符，受违禁词控制<br /> 支持最大长度为：120<br /> 支持的最大列表长度为：120
        /// </summary>
        public string Title { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.ebook.serial.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("author", this.Author);
            parameters.Add("cid", this.Cid);
            parameters.Add("desc", this.Desc);
            parameters.Add("item_id", this.ItemId);
            parameters.Add("name", this.Name);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("price", this.Price);
            parameters.Add("relation_link", this.RelationLink);
            parameters.Add("title", this.Title);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxLength("author", this.Author, 60);
            RequestValidator.ValidateMinValue("cid", this.Cid, 0);
            RequestValidator.ValidateMaxLength("cover", this.Cover, 524288);
            RequestValidator.ValidateMaxLength("desc", this.Desc, 200000);
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateMaxLength("name", this.Name, 60);
            RequestValidator.ValidateMaxLength("title", this.Title, 120);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("cover", this.Cover);
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
