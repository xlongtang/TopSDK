using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ebookmedia.chapter.delete
    /// </summary>
    public class EbookmediaChapterDeleteRequest : ITopRequest<EbookmediaChapterDeleteResponse>
    {
        /// <summary>
        /// 电子书商品数字ID
        /// </summary>
        public Nullable<long> AuctionId { get; set; }

        /// <summary>
        /// 章节的淘宝地址id
        /// </summary>
        public Nullable<long> Tbid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ebookmedia.chapter.delete";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("auction_id", this.AuctionId);
            parameters.Add("tbid", this.Tbid);
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
