using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.xhotel.price.info.get
    /// </summary>
    public class XhotelPriceInfoGetRequest : ITopRequest<XhotelPriceInfoGetResponse>
    {
        /// <summary>
        /// 结束日期，默认值为当前时间加4天,结束日期最多是当前时间加28天
        /// </summary>
        public Nullable<DateTime> EndDate { get; set; }

        /// <summary>
        /// pid
        /// </summary>
        public string Pid { get; set; }

        /// <summary>
        /// 标准酒店id和城市编码拼接字符串，最多50个
        /// </summary>
        public string ShidCityCode { get; set; }

        /// <summary>
        /// 开始时间，默认值为当前时间加3天,开始时间最多是当前时间加28天
        /// </summary>
        public Nullable<DateTime> StartDate { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.xhotel.price.info.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_date", this.EndDate);
            parameters.Add("pid", this.Pid);
            parameters.Add("shid_city_code", this.ShidCityCode);
            parameters.Add("start_date", this.StartDate);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("shid_city_code", this.ShidCityCode);
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
