using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jipiao.agent.order.search
    /// </summary>
    public class JipiaoAgentOrderSearchRequest : ITopRequest<JipiaoAgentOrderSearchResponse>
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
        /// 是否需要行程单，true表示需要行程单；false表示不许要
        /// </summary>
        public Nullable<bool> HasItinerary { get; set; }

        /// <summary>
        /// 页码，默认第一页；注意：页大小固定，搜索结果中返回页大小pageSize，和是否包含下一页hasNext
        /// </summary>
        public Nullable<long> Page { get; set; }

        /// <summary>
        /// 订单状态，默认为空，查询所有状态的订单  1:待确认  2:待出票  3:强制成功  4:未付款  5:预订成功  6:已失效
        /// </summary>
        public Nullable<long> Status { get; set; }

        /// <summary>
        /// 航程类型： 0.单程；1.往返
        /// </summary>
        public Nullable<long> TripType { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jipiao.agent.order.search";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("begin_time", this.BeginTime);
            parameters.Add("end_time", this.EndTime);
            parameters.Add("has_itinerary", this.HasItinerary);
            parameters.Add("page", this.Page);
            parameters.Add("status", this.Status);
            parameters.Add("trip_type", this.TripType);
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
