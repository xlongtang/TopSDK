using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.xhotel.info.list.get
    /// </summary>
    public class XhotelInfoListGetRequest : ITopRequest<XhotelInfoListGetResponse>
    {
        /// <summary>
        /// 城市code
        /// </summary>
        public Nullable<long> CityCode { get; set; }

        /// <summary>
        /// 分页参数：当前页数，从1开始计数。  默认值：1
        /// </summary>
        public Nullable<long> CurrentPage { get; set; }

        /// <summary>
        /// 分页参数：每页酒店数量。最小值1，最大值为50。默认值：20
        /// </summary>
        public Nullable<long> PageSize { get; set; }

        /// <summary>
        /// pid
        /// </summary>
        public string Pid { get; set; }

        /// <summary>
        /// 标准酒店id，如果需要查询单条酒店的信息，需要传入此参数
        /// </summary>
        public Nullable<long> Shid { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.xhotel.info.list.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("city_code", this.CityCode);
            parameters.Add("current_page", this.CurrentPage);
            parameters.Add("page_size", this.PageSize);
            parameters.Add("pid", this.Pid);
            parameters.Add("shid", this.Shid);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("city_code", this.CityCode);
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
