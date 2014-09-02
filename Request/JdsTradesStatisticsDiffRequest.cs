using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jds.trades.statistics.diff
    /// </summary>
    public class JdsTradesStatisticsDiffRequest : ITopRequest<JdsTradesStatisticsDiffResponse>
    {
        /// <summary>
        /// 查询的日期，格式如YYYYMMDD的日期对应的数字
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// 页数
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 需要比较的状态
        /// </summary>
        public string PostStatus { get; set; }

        /// <summary>
        /// 需要比较的状态，将会和post_status做比较
        /// </summary>
        public string PreStatus { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jds.trades.statistics.diff";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("date", this.Date);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("post_status", this.PostStatus);
            parameters.Add("pre_status", this.PreStatus);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("date", this.Date);
            RequestValidator.ValidateRequired("post_status", this.PostStatus);
            RequestValidator.ValidateRequired("pre_status", this.PreStatus);
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
