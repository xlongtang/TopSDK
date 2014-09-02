using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.keyword.keywordforecast.get
    /// </summary>
    public class SimbaKeywordKeywordforecastGetRequest : ITopRequest<SimbaKeywordKeywordforecastGetResponse>
    {
        /// <summary>
        /// 词的出价,范围在5-9999之间,单位分
        /// </summary>
        public Nullable<long> BidwordPrice { get; set; }

        /// <summary>
        /// 词ID
        /// </summary>
        public Nullable<long> KeywordId { get; set; }

        /// <summary>
        /// 经典名表行
        /// </summary>
        public string Nick { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.keyword.keywordforecast.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("bidword_price", this.BidwordPrice);
            parameters.Add("keyword_id", this.KeywordId);
            parameters.Add("nick", this.Nick);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("bidword_price", this.BidwordPrice);
            RequestValidator.ValidateRequired("keyword_id", this.KeywordId);
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
