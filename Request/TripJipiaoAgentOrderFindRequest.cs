using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.trip.jipiao.agent.order.find
    /// </summary>
    public class TripJipiaoAgentOrderFindRequest : ITopRequest<TripJipiaoAgentOrderFindResponse>
    {
        /// <summary>
        /// 创建订单时间范围的开始时间，注意：当前搜索条件开始结束时间范围不能超过三天，默认开始时间为当前时间往前推三天 （具体天数可能调整）
        /// </summary>
        public Nullable<DateTime> BeginTime { get; set; }

        /// <summary>
        /// 创建订单时间范围的结束时间，注意：当前搜索条件开始结束时间范围不能超过三天，默认为当前时间 （具体天数可能调整）
        /// </summary>
        public Nullable<DateTime> EndTime { get; set; }

        /// <summary>
        /// 页码，默认第一页；注意：页大小固定，搜索结果中返回页大小pageSize，和是否包含下一页hasNext
        /// </summary>
        public Nullable<long> Page { get; set; }

        /// <summary>
        /// 淘宝机票政策id
        /// </summary>
        public Nullable<long> PolicyId { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.trip.jipiao.agent.order.find";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("begin_time", this.BeginTime);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("page", this.Page);
            parameters.Add("policy_id", this.PolicyId);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("policy_id", this.PolicyId);
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
