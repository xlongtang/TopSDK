using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaRptCampadgroupbaseGetResponse.
    /// </summary>
    public class SimbaRptCampadgroupbaseGetResponse : TopResponse
    {
        /// <summary>
        /// 推广计划下推广组的基础数据列表
        /// </summary>
        [XmlElement("rpt_campadgroup_base_list")]
        public string RptCampadgroupBaseList { get; set; }
    }
}
