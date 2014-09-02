using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.item.ebook.serial.add
    /// </summary>
    public class ItemEbookSerialAddRequest : ITopUploadRequest<ItemEbookSerialAddResponse>
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
        /// 版权到期时间，如2013-08-06
        /// </summary>
        public Nullable<DateTime> CopyrightEnd { get; set; }

        /// <summary>
        /// 版权文件。不得小于350*500；类型:jpg,png；大小不能超过2M<br /> 支持的文件类型为：jpg,png<br /> 支持的最大列表长度为：2097152
        /// </summary>
        public FileItem CopyrightFiles { get; set; }

        /// <summary>
        /// 商品主图片。类型:JPG,PNG;最大:2M<br /> 支持的文件类型为：gif,jpg,jpeg,png<br /> 支持的最大列表长度为：2097152
        /// </summary>
        public FileItem Cover { get; set; }

        /// <summary>
        /// 宝贝描述。字数要大于5个字符，小于25000个字符，受违禁词控制<br /> 支持最大长度为：200000<br /> 支持的最大列表长度为：200000
        /// </summary>
        public string Desc { get; set; }

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
        /// 售卖方式。目前取值范围0、1；  0：按章节售卖 1：按千字售卖
        /// </summary>
        public Nullable<long> SellWay { get; set; }

        /// <summary>
        /// 宝贝标题。不能超过60字符，受违禁词控制<br /> 支持最大长度为：120<br /> 支持的最大列表长度为：120
        /// </summary>
        public string Title { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.item.ebook.serial.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("author", this.Author);
            parameters.Add("cid", this.Cid);
            parameters.Add("copyright_end", this.CopyrightEnd);
            parameters.Add("desc", this.Desc);
            parameters.Add("name", this.Name);
            parameters.Add("outer_id", this.OuterId);
            parameters.Add("price", this.Price);
            parameters.Add("relation_link", this.RelationLink);
            parameters.Add("sell_way", this.SellWay);
            parameters.Add("title", this.Title);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("author", this.Author);
            RequestValidator.ValidateMaxLength("author", this.Author, 60);
            RequestValidator.ValidateRequired("cid", this.Cid);
            RequestValidator.ValidateMinValue("cid", this.Cid, 0);
            RequestValidator.ValidateRequired("copyright_end", this.CopyrightEnd);
            RequestValidator.ValidateRequired("copyright_files", this.CopyrightFiles);
            RequestValidator.ValidateMaxLength("copyright_files", this.CopyrightFiles, 2097152);
            RequestValidator.ValidateRequired("cover", this.Cover);
            RequestValidator.ValidateMaxLength("cover", this.Cover, 2097152);
            RequestValidator.ValidateRequired("desc", this.Desc);
            RequestValidator.ValidateMaxLength("desc", this.Desc, 200000);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateMaxLength("name", this.Name, 60);
            RequestValidator.ValidateRequired("price", this.Price);
            RequestValidator.ValidateRequired("sell_way", this.SellWay);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateMaxLength("title", this.Title, 120);
        }

        #endregion

        #region ITopUploadRequest Members

        public IDictionary<string, FileItem> GetFileParameters()
        {
            IDictionary<string, FileItem> parameters = new Dictionary<string, FileItem>();
            parameters.Add("copyright_files", this.CopyrightFiles);
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
