using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaRptAdgroupnonsearcheffectGetResponse.
    /// </summary>
    public class SimbaRptAdgroupnonsearcheffectGetResponse : TopResponse
    {
        /// <summary>
        /// 非搜索推广组效果对象
        /// </summary>
        [XmlElement("rpt_adgroup_nonsearch_effect")]
        public string RptAdgroupNonsearchEffect { get; set; }
    }
}
