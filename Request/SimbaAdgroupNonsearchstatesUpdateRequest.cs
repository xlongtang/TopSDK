using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.simba.adgroup.nonsearchstates.update
    /// </summary>
    public class SimbaAdgroupNonsearchstatesUpdateRequest : ITopRequest<SimbaAdgroupNonsearchstatesUpdateResponse>
    {
        /// <summary>
        /// 推广组ID通投状态json数组字符串，数组个数最多200个。json数组中的key必须和对应实体ADGroup 中的属性字段保持一致，否则对应的实体对象属性获取不到相应的值推广组ID,通投状态不传默认为1
        /// </summary>
        public string AdgroupidNonsearchstateJson { get; set; }

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
            return "taobao.simba.adgroup.nonsearchstates.update";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("adgroupid_nonsearchstate_json", this.AdgroupidNonsearchstateJson);
            parameters.Add("campaign_id", this.CampaignId);
            parameters.Add("nick", this.Nick);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("adgroupid_nonsearchstate_json", this.AdgroupidNonsearchstateJson);
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
