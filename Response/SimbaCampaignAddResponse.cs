using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaCampaignAddResponse.
    /// </summary>
    public class SimbaCampaignAddResponse : TopResponse
    {
        /// <summary>
        /// 创建的推广计划
        /// </summary>
        [XmlElement("campaign")]
        public Campaign Campaign { get; set; }
    }
}
