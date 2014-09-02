using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.insight.catsworddata.get
    /// </summary>
    public class SimbaInsightCatsworddataGetRequest : ITopRequest<SimbaInsightCatsworddataGetResponse>
    {
        /// <summary>
        /// 需要查询的关键词列表
        /// </summary>
        public string BidwordList { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        public string CatId { get; set; }

        /// <summary>
        /// 结束时间，格式只能为：yyyy-MM-dd
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 开始时间，格式只能为：yyyy-MM-dd
        /// </summary>
        public string StartDate { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.insight.catsworddata.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("bidword_list", this.BidwordList);
            parameters.Add("cat_id", this.CatId);
            parameters.Add("end_date", this.EndDate);
            parameters.Add("start_date", this.StartDate);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("bidword_list", this.BidwordList);
            RequestValidator.ValidateMaxListSize("bidword_list", this.BidwordList, 5);
            RequestValidator.ValidateRequired("cat_id", this.CatId);
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
