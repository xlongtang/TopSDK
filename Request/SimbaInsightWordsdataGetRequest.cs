using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.insight.wordsdata.get
    /// </summary>
    public class SimbaInsightWordsdataGetRequest : ITopRequest<SimbaInsightWordsdataGetResponse>
    {
        /// <summary>
        /// 关键词列表
        /// </summary>
        public string BidwordList { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public string StartDate { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.insight.wordsdata.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("bidword_list", this.BidwordList);
            parameters.Add("end_date", this.EndDate);
            parameters.Add("start_date", this.StartDate);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("bidword_list", this.BidwordList);
            RequestValidator.ValidateMaxListSize("bidword_list", this.BidwordList, 10);
            RequestValidator.ValidateRequired("end_date", this.EndDate);
            RequestValidator.ValidateRequired("start_date", this.StartDate);
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
