using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaRptCampaignbaseGetResponse.
    /// </summary>
    public class SimbaRptCampaignbaseGetResponse : TopResponse
    {
        /// <summary>
        /// 推广计划查询结果
        /// </summary>
        [XmlElement("rpt_campaign_base_list")]
        public string RptCampaignBaseList { get; set; }
    }
}
