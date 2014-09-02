using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaRptCampaigneffectGetResponse.
    /// </summary>
    public class SimbaRptCampaigneffectGetResponse : TopResponse
    {
        /// <summary>
        /// 推广计划效果报表数据对象
        /// </summary>
        [XmlElement("rpt_campaign_effect_list")]
        public string RptCampaignEffectList { get; set; }
    }
}
