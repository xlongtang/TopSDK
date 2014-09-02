using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.weike.performance.put
    /// </summary>
    public class WeikePerformancePutRequest : ITopRequest<WeikePerformancePutResponse>
    {
        /// <summary>
        /// 订单id
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 绩效数据封装类
        /// </summary>
        public string PerInfoWrapper { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.weike.performance.put";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("id", this.Id);
            parameters.Add("per_info_wrapper", this.PerInfoWrapper);
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
