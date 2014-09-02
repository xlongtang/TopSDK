using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaCampaignPlatformGetResponse.
    /// </summary>
    public class SimbaCampaignPlatformGetResponse : TopResponse
    {
        /// <summary>
        /// 取得的推广计划的投放平台设置
        /// </summary>
        [XmlElement("campaign_platform")]
        public CampaignPlatform CampaignPlatform { get; set; }
    }
}
