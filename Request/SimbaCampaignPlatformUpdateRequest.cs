using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.campaign.platform.update
    /// </summary>
    public class SimbaCampaignPlatformUpdateRequest : ITopRequest<SimbaCampaignPlatformUpdateResponse>
    {
        /// <summary>
        /// 推广计划Id
        /// </summary>
        public Nullable<long> CampaignId { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        public string Nick { get; set; }

        /// <summary>
        /// 非搜索投放频道代码数组，频道代码必须是直通车非搜索类频道列表中的值。
        /// </summary>
        public string NonsearchChannels { get; set; }

        /// <summary>
        /// 溢价的百分比，必须是大于等于 1小于等于200的整数
        /// </summary>
        public Nullable<long> OutsideDiscount { get; set; }

        /// <summary>
        /// 搜索投放频道代码数组，频道代码必须是直通车搜索类频道列表中的值，必须包含淘宝内网。
        /// </summary>
        public string SearchChannels { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.campaign.platform.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("campaign_id", this.CampaignId);
            parameters.Add("nick", this.Nick);
            parameters.Add("nonsearch_channels", this.NonsearchChannels);
            parameters.Add("outside_discount", this.OutsideDiscount);
            parameters.Add("search_channels", this.SearchChannels);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("campaign_id", this.CampaignId);
            RequestValidator.ValidateMaxListSize("nonsearch_channels", this.NonsearchChannels, 10);
            RequestValidator.ValidateRequired("outside_discount", this.OutsideDiscount);
            RequestValidator.ValidateMaxValue("outside_discount", this.OutsideDiscount, 200);
            RequestValidator.ValidateMinValue("outside_discount", this.OutsideDiscount, 1);
            RequestValidator.ValidateRequired("search_channels", this.SearchChannels);
            RequestValidator.ValidateMaxListSize("search_channels", this.SearchChannels, 10);
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
