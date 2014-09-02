using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.sp.item.feed.info.get
    /// </summary>
    public class SpItemFeedInfoGetRequest : ITopRequest<SpItemFeedInfoGetResponse>
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        public string ItemId { get; set; }

        /// <summary>
        /// 卖家数字ID
        /// </summary>
        public string SellerId { get; set; }

        /// <summary>
        /// 每个站点的唯一Key(加密的site id)
        /// </summary>
        public string SiteKey { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.sp.item.feed.info.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("item_id", this.ItemId);
            parameters.Add("seller_id", this.SellerId);
            parameters.Add("site_key", this.SiteKey);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("item_id", this.ItemId);
            RequestValidator.ValidateRequired("seller_id", this.SellerId);
            RequestValidator.ValidateRequired("site_key", this.SiteKey);
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
