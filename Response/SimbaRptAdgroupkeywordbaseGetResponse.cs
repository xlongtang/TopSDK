using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaRptAdgroupkeywordbaseGetResponse.
    /// </summary>
    public class SimbaRptAdgroupkeywordbaseGetResponse : TopResponse
    {
        /// <summary>
        /// 词基础数据返回结果
        /// </summary>
        [XmlElement("rpt_adgroupkeyword_base_list")]
        public string RptAdgroupkeywordBaseList { get; set; }
    }
}
