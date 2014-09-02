using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.topats.simba.campkeywordeffect.get
    /// </summary>
    public class TopatsSimbaCampkeywordeffectGetRequest : ITopRequest<TopatsSimbaCampkeywordeffectGetResponse>
    {
        /// <summary>
        /// 查询推广计划ID
        /// </summary>
        public Nullable<long> CampaignId { get; set; }

        /// <summary>
        /// 查询的昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 报表类型。可选值：SEARCH（搜索）、CAT（类目出价）、 NOSEARCH（定向投放），可多选，如：SEARCH,CAT
        /// </summary>
        public string SearchType { get; set; }

        /// <summary>
        /// 数据来源。可选值：1（站内）、2（站外）、SUMMARY（汇总），其中SUMMARY必须单选，其它值可多选，如：1,2
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// 时间参数（昨天：DAY、 前一周：7DAY、 前15天：15DAY、 前30天：30DAY 、前90天：90DAY）单选
        /// </summary>
        public string TimeSlot { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.topats.simba.campkeywordeffect.get";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("campaign_id", this.CampaignId);
            parameters.Add("nick", this.Nick);
            parameters.Add("search_type", this.SearchType);
            parameters.Add("source", this.Source);
            parameters.Add("time_slot", this.TimeSlot);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("campaign_id", this.CampaignId);
            RequestValidator.ValidateRequired("search_type", this.SearchType);
            RequestValidator.ValidateRequired("source", this.Source);
            RequestValidator.ValidateRequired("time_slot", this.TimeSlot);
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
