using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.ebook.order.search
    /// </summary>
    public class EbookOrderSearchRequest : ITopRequest<EbookOrderSearchResponse>
    {
        /// <summary>
        /// 查询截止日期，yyyy-MM-dd HH:mm:ss，查询时间跨度为90天。
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 当前页码，不可为空、0和负数。
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页的大小，不可为空、0和负数。最大为30，如果超过30，则取默认的20。
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 查询开始日期，yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string StartDate { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.ebook.order.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_date", this.EndDate);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_date", this.StartDate);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("end_date", this.EndDate);
            RequestValidator.ValidateRequired("page_no", this.PageNo);
            RequestValidator.ValidateRequired("page_size", this.PageSize);
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
