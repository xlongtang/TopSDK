using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaCampaignBudgetGetResponse.
    /// </summary>
    public class SimbaCampaignBudgetGetResponse : TopResponse
    {
        /// <summary>
        /// 推广计划日限额
        /// </summary>
        [XmlElement("campaign_budget")]
        public CampaignBudget CampaignBudget { get; set; }
    }
}
