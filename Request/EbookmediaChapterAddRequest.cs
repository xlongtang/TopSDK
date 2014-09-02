using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ebookmedia.chapter.add
    /// </summary>
    public class EbookmediaChapterAddRequest : ITopRequest<EbookmediaChapterAddResponse>
    {
        /// <summary>
        /// 电子书商品ID
        /// </summary>
        public Nullable<long> AuctionId { get; set; }

        /// <summary>
        /// 电子书完本价格。当状态为完本（即status=3）时，必填；只支持两位小数点的正数，例如：12.50
        /// </summary>
        public string BookPrice { get; set; }

        /// <summary>
        /// 章节内容，最大长度不超过50000个字符
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 章节内容地址,只有通过授权的用户才可以传入此参数,不能超过500个字符
        /// </summary>
        public string ContentUrl { get; set; }

        /// <summary>
        /// 第三方的章节ID。不能为空，必须是大于0的数字，同一个商品下不能重复
        /// </summary>
        public Nullable<long> CpCid { get; set; }

        /// <summary>
        /// 是否免费.值只能是0或者1  0：收费，1：免费
        /// </summary>
        public Nullable<long> IsFree { get; set; }

        /// <summary>
        /// 上一章节的淘宝地址id。不能为空，若添加的章节是第一章，则填0
        /// </summary>
        public Nullable<long> PreTbid { get; set; }

        /// <summary>
        /// 章节的收费字数
        /// </summary>
        public Nullable<long> PriceCount { get; set; }

        /// <summary>
        /// 电子书状态。目前仅支持以下三种  1：更新中，3：完本，2：暂停
        /// </summary>
        public Nullable<long> Status { get; set; }

        /// <summary>
        /// 章节标题。不能为空，不超过30个字符
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 电子书章节所属的卷ID
        /// </summary>
        public Nullable<long> VolumeId { get; set; }

        /// <summary>
        /// 章节的总字数。总字数必须大于或等于收费字数
        /// </summary>
        public Nullable<long> WordCount { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ebookmedia.chapter.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auction_id", this.AuctionId);
            parameters.Add("book_price", this.BookPrice);
            parameters.Add("content", this.Content);
            parameters.Add("content_url", this.ContentUrl);
            parameters.Add("cp_cid", this.CpCid);
            parameters.Add("is_free", this.IsFree);
            parameters.Add("pre_tbid", this.PreTbid);
            parameters.Add("price_count", this.PriceCount);
            parameters.Add("status", this.Status);
            parameters.Add("title", this.Title);
            parameters.Add("volume_id", this.VolumeId);
            parameters.Add("word_count", this.WordCount);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("auction_id", this.AuctionId);
            RequestValidator.ValidateRequired("cp_cid", this.CpCid);
            RequestValidator.ValidateRequired("is_free", this.IsFree);
            RequestValidator.ValidateRequired("pre_tbid", this.PreTbid);
            RequestValidator.ValidateRequired("price_count", this.PriceCount);
            RequestValidator.ValidateRequired("status", this.Status);
            RequestValidator.ValidateRequired("title", this.Title);
            RequestValidator.ValidateRequired("volume_id", this.VolumeId);
            RequestValidator.ValidateRequired("word_count", this.WordCount);
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
