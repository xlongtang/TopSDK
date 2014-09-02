using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaRptAdgroupeffectGetResponse.
    /// </summary>
    public class SimbaRptAdgroupeffectGetResponse : TopResponse
    {
        /// <summary>
        /// 推广组效果报表数据对象
        /// </summary>
        [XmlElement("rpt_adgroup_effect_list")]
        public string RptAdgroupEffectList { get; set; }
    }
}
