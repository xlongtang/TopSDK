using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaRptAdgroupcreativeeffectGetResponse.
    /// </summary>
    public class SimbaRptAdgroupcreativeeffectGetResponse : TopResponse
    {
        /// <summary>
        /// 推广组下的创意效果数据列表
        /// </summary>
        [XmlElement("rpt_adgroupcreative_effect_list")]
        public string RptAdgroupcreativeEffectList { get; set; }
    }
}
