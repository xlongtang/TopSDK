using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ebookmedia.chapter.update
    /// </summary>
    public class EbookmediaChapterUpdateRequest : ITopRequest<EbookmediaChapterUpdateResponse>
    {
        /// <summary>
        /// 电子书商品ID
        /// </summary>
        public Nullable<long> AuctionId { get; set; }

        /// <summary>
        /// 章节内容，最大长度不超过50000个字符
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 章节内容地址,只有通过授权的用户才可以传入此参数,不能超过500个字符
        /// </summary>
        public string ContentUrl { get; set; }

        /// <summary>
        /// 是否免费.值只能是0或者1  0：收费，1：免费
        /// </summary>
        public Nullable<long> IsFree { get; set; }

        /// <summary>
        /// 章节的收费字数
        /// </summary>
        public Nullable<long> PriceCount { get; set; }

        /// <summary>
        /// 需要修改的章节的淘宝地址id。不能为空
        /// </summary>
        public Nullable<long> Tbid { get; set; }

        /// <summary>
        /// 章节标题。不能为空，不超过30个字符
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 章节的总字数。总字数必须大于或等于收费字数
        /// </summary>
        public Nullable<long> WordCount { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ebookmedia.chapter.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auction_id", this.AuctionId);
            parameters.Add("content", this.Content);
            parameters.Add("content_url", this.ContentUrl);
            parameters.Add("is_free", this.IsFree);
            parameters.Add("price_count", this.PriceCount);
            parameters.Add("tbid", this.Tbid);
            parameters.Add("title", this.Title);
            parameters.Add("word_count", this.WordCount);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("auction_id", this.AuctionId);
            RequestValidator.ValidateRequired("tbid", this.Tbid);
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
