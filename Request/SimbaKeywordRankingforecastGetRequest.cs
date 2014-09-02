using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.keyword.rankingforecast.get
    /// </summary>
    public class SimbaKeywordRankingforecastGetRequest : ITopRequest<SimbaKeywordRankingforecastGetResponse>
    {
        /// <summary>
        /// 关键词Id列表，最多支持1个
        /// </summary>
        public string KeywordIds { get; set; }

        /// <summary>
        /// 经典名表行
        /// </summary>
        public string Nick { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.keyword.rankingforecast.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("keyword_ids", this.KeywordIds);
            parameters.Add("nick", this.Nick);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("keyword_ids", this.KeywordIds);
            RequestValidator.ValidateMaxListSize("keyword_ids", this.KeywordIds, 1);
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
