using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.adgroupids.deleted.get
    /// </summary>
    public class SimbaAdgroupidsDeletedGetRequest : ITopRequest<SimbaAdgroupidsDeletedGetResponse>
    {
        /// <summary>
        /// 主人昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 返回的第几页数据，默认为1<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageNo { get; set; }

        /// <summary>
        /// 返回的每页数据量大小,默认200最大1000<br /> 支持最大值为：1000<br /> 支持最小值为：1
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// 得到此时间点之后的数据，不能大于一个月
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.adgroupids.deleted.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("nick", this.Nick);
            parameters.Add("page_no", this.PageNo);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("start_time", this.StartTime);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMinValue("page_no", this.PageNo, 1);
            RequestValidator.ValidateMaxValue("page_size", this.PageSize, 1000);
            RequestValidator.ValidateMinValue("page_size", this.PageSize, 1);
            RequestValidator.ValidateRequired("start_time", this.StartTime);
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
