using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.dd.auction.rule.add
    /// </summary>
    public class DdAuctionRuleAddRequest : ITopRequest<DdAuctionRuleAddResponse>
    {
        /// <summary>
        /// 每天的结束时间 ， 格式：10000*hh+100*mm+ss
        /// </summary>
        public Nullable<long> DayEnd { get; set; }

        /// <summary>
        /// 每天的开始时间， 格式：10000*hh+100*mm+ss
        /// </summary>
        public Nullable<long> DayStart { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        public string Features { get; set; }

        /// <summary>
        /// 是否是点点商品规则
        /// </summary>
        public Nullable<bool> IsDiandian { get; set; }

        /// <summary>
        /// 是否是外卖商品规则
        /// </summary>
        public Nullable<bool> IsTakeout { get; set; }

        /// <summary>
        /// 商户规则名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 规则结束时间
        /// </summary>
        public Nullable<DateTime> RuleEnd { get; set; }

        /// <summary>
        /// 规则开始时间
        /// </summary>
        public Nullable<DateTime> RuleStart { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public Nullable<long> Sort { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public Nullable<long> Status { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        public string StoreId { get; set; }

        /// <summary>
        /// 周期轮询0,1,2,3通过逗号间隔
        /// </summary>
        public string Weeklys { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.dd.auction.rule.add";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("day_end", this.DayEnd);
            parameters.Add("day_start", this.DayStart);
            parameters.Add("features", this.Features);
            parameters.Add("is_diandian", this.IsDiandian);
            parameters.Add("is_takeout", this.IsTakeout);
            parameters.Add("name", this.Name);
            parameters.Add("rule_end", this.RuleEnd);
            parameters.Add("rule_start", this.RuleStart);
            parameters.Add("sort", this.Sort);
            parameters.Add("status", this.Status);
            parameters.Add("store_id", this.StoreId);
            parameters.Add("weeklys", this.Weeklys);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("is_diandian", this.IsDiandian);
            RequestValidator.ValidateRequired("is_takeout", this.IsTakeout);
            RequestValidator.ValidateRequired("name", this.Name);
            RequestValidator.ValidateRequired("store_id", this.StoreId);
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
