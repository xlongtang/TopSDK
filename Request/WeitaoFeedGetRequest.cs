using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.weitao.feed.get
    /// </summary>
    public class WeitaoFeedGetRequest : ITopRequest<WeitaoFeedGetResponse>
    {
        /// <summary>
        /// feed的Id<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> FeedId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.weitao.feed.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("feed_id", this.FeedId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("feed_id", this.FeedId);
            RequestValidator.ValidateMinValue("feed_id", this.FeedId, 1);
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
