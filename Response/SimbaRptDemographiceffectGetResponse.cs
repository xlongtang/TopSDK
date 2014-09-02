using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaRptDemographiceffectGetResponse.
    /// </summary>
    public class SimbaRptDemographiceffectGetResponse : TopResponse
    {
        /// <summary>
        /// 推广计划下的人群维度效果数据查询
        /// </summary>
        [XmlElement("rpt_demographic_effect")]
        public string RptDemographicEffect { get; set; }
    }
}
