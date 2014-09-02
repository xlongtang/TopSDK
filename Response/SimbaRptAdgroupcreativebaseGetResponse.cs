using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaRptAdgroupcreativebaseGetResponse.
    /// </summary>
    public class SimbaRptAdgroupcreativebaseGetResponse : TopResponse
    {
        /// <summary>
        /// 推广组下的创意基础数据列表
        /// </summary>
        [XmlElement("rpt_adgroupcreative_base_list")]
        public string RptAdgroupcreativeBaseList { get; set; }
    }
}
