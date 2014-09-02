using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.weike.subscinfo.get
    /// </summary>
    public class WeikeSubscinfoGetRequest : ITopRequest<WeikeSubscinfoGetResponse>
    {
        /// <summary>
        /// 时间范围结束时间
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public Nullable<long> PageNum { get; set; }

        /// <summary>
        /// 商家旺旺名称
        /// </summary>
        public string SellerName { get; set; }

        /// <summary>
        /// 时间范围开始时间
        /// </summary>
        public Nullable<DateTime> StartTime { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.weike.subscinfo.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("end_time", this.EndTime);
            parameters.Add("page_num", this.PageNum);
            parameters.Add("seller_name", this.SellerName);
            parameters.Add("start_time", this.StartTime);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
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
