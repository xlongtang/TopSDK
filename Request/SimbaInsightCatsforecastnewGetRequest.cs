using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.insight.catsforecastnew.get
    /// </summary>
    public class SimbaInsightCatsforecastnewGetRequest : ITopRequest<SimbaInsightCatsforecastnewGetResponse>
    {
        /// <summary>
        /// 需要查询的词列表
        /// </summary>
        public string BidwordList { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.insight.catsforecastnew.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("bidword_list", this.BidwordList);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("bidword_list", this.BidwordList);
            RequestValidator.ValidateMaxListSize("bidword_list", this.BidwordList, 10);
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
