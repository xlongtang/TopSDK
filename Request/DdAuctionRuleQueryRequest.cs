using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.dd.auction.rule.query
    /// </summary>
    public class DdAuctionRuleQueryRequest : ITopRequest<DdAuctionRuleQueryResponse>
    {
        /// <summary>
        /// 当前日期时间
        /// </summary>
        public Nullable<DateTime> CurrentDate { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public Nullable<long> DayTime { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        public Nullable<long> Id { get; set; }

        /// <summary>
        /// 是否是到店
        /// </summary>
        public Nullable<bool> IsDiandian { get; set; }

        /// <summary>
        /// 是否是外卖
        /// </summary>
        public Nullable<bool> IsTakeout { get; set; }

        /// <summary>
        /// 规则名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 状态数组string
        /// </summary>
        public string StatusArray { get; set; }

        /// <summary>
        /// 商铺ID
        /// </summary>
        public string StoreId { get; set; }

        /// <summary>
        /// 轮询周期
        /// </summary>
        public string Weekly { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.dd.auction.rule.query";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("current_date", this.CurrentDate);
            parameters.Add("day_time", this.DayTime);
            parameters.Add("id", this.Id);
            parameters.Add("is_diandian", this.IsDiandian);
            parameters.Add("is_takeout", this.IsTakeout);
            parameters.Add("name", this.Name);
            parameters.Add("status_array", this.StatusArray);
            parameters.Add("store_id", this.StoreId);
            parameters.Add("weekly", this.Weekly);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("is_diandian", this.IsDiandian);
            RequestValidator.ValidateRequired("is_takeout", this.IsTakeout);
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
