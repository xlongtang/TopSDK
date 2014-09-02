using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaRptDemographicbaseGetResponse.
    /// </summary>
    public class SimbaRptDemographicbaseGetResponse : TopResponse
    {
        /// <summary>
        /// 非搜索推广计划基础数据对象
        /// </summary>
        [XmlElement("rpt_demographic_base")]
        public string RptDemographicBase { get; set; }
    }
}
