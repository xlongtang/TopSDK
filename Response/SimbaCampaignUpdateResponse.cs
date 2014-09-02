using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaCampaignUpdateResponse.
    /// </summary>
    public class SimbaCampaignUpdateResponse : TopResponse
    {
        /// <summary>
        /// 修改后的推广计划
        /// </summary>
        [XmlElement("campaign")]
        public Campaign Campaign { get; set; }
    }
}
