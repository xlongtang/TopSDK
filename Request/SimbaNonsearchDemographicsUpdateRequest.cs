using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.nonsearch.demographics.update
    /// </summary>
    public class SimbaNonsearchDemographicsUpdateRequest : ITopRequest<SimbaNonsearchDemographicsUpdateResponse>
    {
        /// <summary>
        /// 推广计划ID
        /// </summary>
        public Nullable<long> CampaignId { get; set; }

        /// <summary>
        /// 投放人群维度Id，加价json数组字符串。数组长度不能超过15，json数组中的key必须和相应实体DemographicSetting中的属性字段保持一致，否则对应的实体对象属性获取不到相应的值  incrementalPrice是整数，以“分”为单位，不能小于1，不能大于日限额,不能大于9999分; 可以为0表示不加价；投放人群维度ID必须有效
        /// </summary>
        public string DemographicIdPriceJson { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        public string Nick { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.nonsearch.demographics.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("campaign_id", this.CampaignId);
            parameters.Add("demographic_id_price_json", this.DemographicIdPriceJson);
            parameters.Add("nick", this.Nick);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("campaign_id", this.CampaignId);
            RequestValidator.ValidateRequired("demographic_id_price_json", this.DemographicIdPriceJson);
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
