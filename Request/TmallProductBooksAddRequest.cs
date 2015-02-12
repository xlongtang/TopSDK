using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: tmall.product.books.add
    /// </summary>
    public class TmallProductBooksAddRequest : ITopUploadRequest<TmallProductBooksAddResponse>
    {
        /// <summary>
        /// 摘要信息，不支持HTML代码，长度限制5000
        /// </summary>
        public string AbstractMsg { get; set; }

        /// <summary>
        /// 用户的Id,需要确定自己id的可以联系接口负责人
        /// </summary>
        public string AppInfo { get; set; }

        /// <summary>
        /// 作者/著者，最多填写三个人名，超出三个人的以“等”结束
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 作者国别/地区，到国家级别
        /// </summary>
        public string AuthorArea { get; set; }

        /// <summary>
        /// 条形码，数字，共13位，9787开头
        /// </summary>
        public string BarCode { get; set; }

        /// <summary>
        /// 装帧
        /// </summary>
        public string BookBind { get; set; }

        /// <summary>
        /// 开本，如：16  表示16开本
        /// </summary>
        public Nullable<long> BookSize { get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        public Nullable<long> BookVersion { get; set; }

        /// <summary>
        /// 目录，不支持HTML代码，长度限制为8000
        /// </summary>
        public string Catalog { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// 中图分类号，英文字母加数字组成
        /// </summary>
        public string ChinaClassifyNo { get; set; }

        /// <summary>
        /// cip数据编号，真实格式：（XXX）第***号，  导入时，格式为XXX-***
        /// </summary>
        public string Cip { get; set; }

        /// <summary>
        /// 点评者，只写一个人的名字，超出的以“等”结束
        /// </summary>
        public string Commentator { get; set; }

        /// <summary>
        /// 用户自己的Id号
        /// </summary>
        public string CustomId { get; set; }

        /// <summary>
        /// 图书名称(正副书名)
        /// </summary>
        public string DeputyName { get; set; }

        /// <summary>
        /// 绘图者，只写一个人的名字，超出的以“等”结束
        /// </summary>
        public string Drawor { get; set; }

        /// <summary>
        /// 编者，只写一个人的名字，超出的以“等”结束
        /// </summary>
        public string Editor { get; set; }

        /// <summary>
        /// 摄影者，只写一个人的名字，超出的以“等”结束
        /// </summary>
        public string Graphor { get; set; }

        /// <summary>
        /// 上传图片，图片上传使用byte[]类型
        /// </summary>
        public FileItem Image { get; set; }

        /// <summary>
        /// 不带‘-’的图书ISBN号  1. 位数限定：10位 末尾校验,7开头  2. 位数限定：13位、开头数字限定： 9787开头
        /// </summary>
        public string Isbn { get; set; }

        /// <summary>
        /// 这条记录对应的淘宝的Ids
        /// </summary>
        public string ItemIds { get; set; }

        /// <summary>
        /// 口述者，只写一个人的名字，超出的以“等”结束
        /// </summary>
        public string Narrator { get; set; }

        /// <summary>
        /// 分册名
        /// </summary>
        public string PartName { get; set; }

        /// <summary>
        /// 分册号
        /// </summary>
        public Nullable<long> PartNo { get; set; }

        /// <summary>
        /// 策划者，只写一个人的名字，超出的以“等”结束
        /// </summary>
        public string Plottor { get; set; }

        /// <summary>
        /// 价格支持整数和小数，小数保留小数点后两位，若有多个价格，价格之间通过','号分隔
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// 出版社名称
        /// </summary>
        public string PublishCompany { get; set; }

        /// <summary>
        /// 出版时间，格式必须注意：年份/月份
        /// </summary>
        public string PublishYm { get; set; }

        /// <summary>
        /// 年号，必须是完整的年份，如：2013，当输入的值不是四位或者首位大于2时，调接口失败
        /// </summary>
        public string ReginYear { get; set; }

        /// <summary>
        /// 注释者，只写一个人的名字，超出的以“等”结束
        /// </summary>
        public string Scholisat { get; set; }

        /// <summary>
        /// 丛书名
        /// </summary>
        public string SeriesBooksName { get; set; }

        /// <summary>
        /// 此字段废弃
        /// </summary>
        public string SpuImg { get; set; }

        /// <summary>
        /// 简介，不支持HTML代码，长度不能超过5000
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 译者，只写一个人的名字，超出的以“等”结束
        /// </summary>
        public string Translator { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "tmall.product.books.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("abstract_msg", this.AbstractMsg);
            parameters.Add("app_info", this.AppInfo);
            parameters.Add("author", this.Author);
            parameters.Add("author_area", this.AuthorArea);
            parameters.Add("bar_code", this.BarCode);
            parameters.Add("book_bind", this.BookBind);
            parameters.Add("book_size", this.BookSize);
            parameters.Add("book_version", this.BookVersion);
            parameters.Add("catalog", this.Catalog);
            parameters.Add("category_id", this.CategoryId);
            parameters.Add("china_classify_no", this.ChinaClassifyNo);
            parameters.Add("cip", this.Cip);
            parameters.Add("commentator", this.Commentator);
            parameters.Add("custom_id", this.CustomId);
            parameters.Add("deputy_name", this.DeputyName);
            parameters.Add("drawor", this.Drawor);
            parameters.Add("editor", this.Editor);
            parameters.Add("graphor", this.Graphor);
            parameters.Add("isbn", this.Isbn);
            parameters.Add("item_ids", this.ItemIds);
            parameters.Add("narrator", this.Narrator);
            parameters.Add("part_name", this.PartName);
            parameters.Add("part_no", this.PartNo);
            parameters.Add("plottor", this.Plottor);
            parameters.Add("price", this.Price);
            parameters.Add("publish_company", this.PublishCompany);
            parameters.Add("publish_ym", this.PublishYm);
            parameters.Add("regin_year", this.ReginYear);
            parameters.Add("scholisat", this.Scholisat);
            parameters.Add("series_books_name", this.SeriesBooksName);
            parameters.Add("spu_img", this.SpuImg);
            parameters.Add("summary", this.Summary);
            parameters.Add("translator", this.Translator);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("app_info", this.AppInfo);
            RequestValidator.ValidateMaxLength("app_info", this.AppInfo, 40);
            RequestValidator.ValidateRequired("author", this.Author);
            RequestValidator.ValidateMaxLength("author", this.Author, 80);
            RequestValidator.ValidateMaxLength("author_area", this.AuthorArea, 80);
            RequestValidator.ValidateRequired("bar_code", this.BarCode);
            RequestValidator.ValidateMaxLength("bar_code", this.BarCode, 20);
            RequestValidator.ValidateRequired("book_bind", this.BookBind);
            RequestValidator.ValidateMaxLength("book_bind", this.BookBind, 10);
            RequestValidator.ValidateMaxLength("catalog", this.Catalog, 8000);
            RequestValidator.ValidateRequired("category_id", this.CategoryId);
            RequestValidator.ValidateMaxListSize("category_id", this.CategoryId, 40);
            RequestValidator.ValidateMaxLength("china_classify_no", this.ChinaClassifyNo, 30);
            RequestValidator.ValidateMaxLength("cip", this.Cip, 50);
            RequestValidator.ValidateMaxLength("commentator", this.Commentator, 40);
            RequestValidator.ValidateRequired("custom_id", this.CustomId);
            RequestValidator.ValidateRequired("deputy_name", this.DeputyName);
            RequestValidator.ValidateMaxLength("deputy_name", this.DeputyName, 150);
            RequestValidator.ValidateMaxLength("drawor", this.Drawor, 40);
            RequestValidator.ValidateMaxLength("editor", this.Editor, 40);
            RequestValidator.ValidateMaxLength("graphor", this.Graphor, 40);
            RequestValidator.ValidateRequired("isbn", this.Isbn);
            RequestValidator.ValidateMaxLength("isbn", this.Isbn, 13);
            RequestValidator.ValidateMaxLength("narrator", this.Narrator, 40);
            RequestValidator.ValidateMaxLength("part_name", this.PartName, 150);
            RequestValidator.ValidateMaxLength("plottor", this.Plottor, 40);
            RequestValidator.ValidateRequired("price", this.Price);
            RequestValidator.ValidateMaxLength("price", this.Price, 40);
            RequestValidator.ValidateMaxLength("publish_company", this.PublishCompany, 80);
            RequestValidator.ValidateMaxLength("regin_year", this.ReginYear, 10);
            RequestValidator.ValidateMaxLength("scholisat", this.Scholisat, 40);
            RequestValidator.ValidateMaxLength("series_books_name", this.SeriesBooksName, 150);
            RequestValidator.ValidateMaxLength("spu_img", this.SpuImg, 150);
            RequestValidator.ValidateMaxLength("summary", this.Summary, 5000);
            RequestValidator.ValidateMaxLength("translator", this.Translator, 40);
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
