using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.fuwu.scores.get
    /// </summary>
    public class FuwuScoresGetRequest : ITopRequest<FuwuScoresGetResponse>
    {
        /// <summary>
        /// 当前页
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 评价日期，查询某一天的评价
        /// </summary>
        public Nullable<DateTime> Date { get; set; }

        /// <summary>
        /// 每页获取条数。默认值40，最小值1，最大值100。
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.fuwu.scores.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("date", this.Date);
            parameters.Add("page_size", this.PageSize);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("current_page", this.CurrentPage);
            RequestValidator.ValidateRequired("date", this.Date);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 100);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
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
