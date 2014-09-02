using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.insight.relatedwords.get
    /// </summary>
    public class SimbaInsightRelatedwordsGetRequest : ITopRequest<SimbaInsightRelatedwordsGetResponse>
    {
        /// <summary>
        /// 要查询的词列表
        /// </summary>
        public string BidwordList { get; set; }

        /// <summary>
        /// 表示返回数据的条数<br /> 支持最大值为：10<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> Number { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.insight.relatedwords.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("bidword_list", this.BidwordList);
            parameters.Add("number", this.Number);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("bidword_list", this.BidwordList);
            RequestValidator.ValidateMaxListSize("bidword_list", this.BidwordList, 10);
            RequestValidator.ValidateRequired("number", this.Number);
            RequestValidator.ValidateMaxValue("number", this.Number, 10);
            RequestValidator.ValidateMinValue("number", this.Number, 1);
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
