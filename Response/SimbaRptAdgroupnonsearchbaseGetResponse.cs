using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaRptAdgroupnonsearchbaseGetResponse.
    /// </summary>
    public class SimbaRptAdgroupnonsearchbaseGetResponse : TopResponse
    {
        /// <summary>
        /// 非搜索推广组基础对象
        /// </summary>
        [XmlElement("rpt_adgroup_nonsearch_base")]
        public string RptAdgroupNonsearchBase { get; set; }
    }
}
