using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.insight.catsdata.get
    /// </summary>
    public class SimbaInsightCatsdataGetRequest : ITopRequest<SimbaInsightCatsdataGetResponse>
    {
        /// <summary>
        /// 表示要查询的类目id
        /// </summary>
        public string CategoryIdList { get; set; }

        /// <summary>
        /// 查询截止时间，格式：yyyy-MM-dd
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 开始时间，格式：yyyy-MM-dd
        /// </summary>
        public string StartDate { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.insight.catsdata.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("category_id_list", this.CategoryIdList);
            parameters.Add("end_date", this.EndDate);
            parameters.Add("start_date", this.StartDate);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("category_id_list", this.CategoryIdList);
            RequestValidator.ValidateMaxListSize("category_id_list", this.CategoryIdList, 5);
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
