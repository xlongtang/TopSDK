using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.caipiao.present.items.get
    /// </summary>
    public class CaipiaoPresentItemsGetRequest : ITopRequest<CaipiaoPresentItemsGetResponse>
    {
        /// <summary>
        /// 赠送订单的截止时间，格式为yyyyMMdd, 距当前最长时间间隔是3个月，最近可以取当天的时间。不可为空。要求endDate-startDate必须<=3个月，
        /// </summary>
        public string EndDate { get; set; }

        /// <summary>
        /// 当前页码， 不可为空、0和负数。
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 每页的大小，不可为空、0和负数。最大为500，如果超过500，则取默认的500.
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 赠送订单的开始时间， 格式为yyyyMMdd, 距当前最长时间间隔是3个月， 最近可以取当天的时间. 不可为空。
        /// </summary>
        public string StartDate { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.caipiao.present.items.get";
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
