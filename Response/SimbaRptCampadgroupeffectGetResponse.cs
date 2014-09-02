using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaRptCampadgroupeffectGetResponse.
    /// </summary>
    public class SimbaRptCampadgroupeffectGetResponse : TopResponse
    {
        /// <summary>
        /// 推广计划下推广组的效果数据列表
        /// </summary>
        [XmlElement("rpt_campadgroup_effect_list")]
        public string RptCampadgroupEffectList { get; set; }
    }
}
