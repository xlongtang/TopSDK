using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaCampaignAreaGetResponse.
    /// </summary>
    public class SimbaCampaignAreaGetResponse : TopResponse
    {
        /// <summary>
        /// 推广计划的投放地域配置
        /// </summary>
        [XmlElement("campaign_area")]
        public CampaignArea CampaignArea { get; set; }
    }
}
