using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.campaign.budget.update
    /// </summary>
    public class SimbaCampaignBudgetUpdateRequest : ITopRequest<SimbaCampaignBudgetUpdateResponse>
    {
        /// <summary>
        /// 如果为空则取消限额；否则必须为整数，单位是元，不得小于30；
        /// </summary>
        public Nullable<long> Budget { get; set; }

        /// <summary>
        /// 推广计划Id
        /// </summary>
        public Nullable<long> CampaignId { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 是否平滑消耗：false-否，true-是
        /// </summary>
        public Nullable<bool> UseSmooth { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.campaign.budget.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("budget", this.Budget);
            parameters.Add("campaign_id", this.CampaignId);
            parameters.Add("nick", this.Nick);
            parameters.Add("use_smooth", this.UseSmooth);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateMaxValue("budget", this.Budget, 99999);
            RequestValidator.ValidateMinValue("budget", this.Budget, 30);
            RequestValidator.ValidateRequired("campaign_id", this.CampaignId);
            RequestValidator.ValidateRequired("use_smooth", this.UseSmooth);
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
