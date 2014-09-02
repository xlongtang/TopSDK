using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaRptAdgroupkeywordeffectGetResponse.
    /// </summary>
    public class SimbaRptAdgroupkeywordeffectGetResponse : TopResponse
    {
        /// <summary>
        /// 词效果数据返回结果
        /// </summary>
        [XmlElement("rpt_adgroupkeyword_effect_list")]
        public string RptAdgroupkeywordEffectList { get; set; }
    }
}
