using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaCampaignBudgetUpdateResponse.
    /// </summary>
    public class SimbaCampaignBudgetUpdateResponse : TopResponse
    {
        /// <summary>
        /// 修改后的推广计划日限额
        /// </summary>
        [XmlElement("campaign_budget")]
        public CampaignBudget CampaignBudget { get; set; }
    }
}
