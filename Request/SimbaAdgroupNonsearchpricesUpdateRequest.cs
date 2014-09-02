using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.adgroup.nonsearchprices.update
    /// </summary>
    public class SimbaAdgroupNonsearchpricesUpdateRequest : ITopRequest<SimbaAdgroupNonsearchpricesUpdateResponse>
    {
        /// <summary>
        /// 推广组id，通投位置价格，是否使用默认出价json 数组字符串，数组个数最多200个.  json数组中的key必须和对应实体ADGroup中的属性字段保持一致，否则对应的实体对象属性获取不到相应的值，  adgroupId,isNonsearchDefaultPrice不能为空。nonsearchMaxPrice是整数，以“分”为单位，不能小于5，不能大于日限额,不能大于9999分。 启用非搜索默认出价时nonsearchMaxPrice为0
        /// </summary>
        public string AdgroupidPriceJson { get; set; }

        /// <summary>
        /// 推广计划ID
        /// </summary>
        public Nullable<long> CampaignId { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        public string Nick { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.simba.adgroup.nonsearchprices.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("adgroupid_price_json", this.AdgroupidPriceJson);
            parameters.Add("campaign_id", this.CampaignId);
            parameters.Add("nick", this.Nick);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("adgroupid_price_json", this.AdgroupidPriceJson);
            RequestValidator.ValidateRequired("campaign_id", this.CampaignId);
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
