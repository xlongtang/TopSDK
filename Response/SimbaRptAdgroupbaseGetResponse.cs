using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaRptAdgroupbaseGetResponse.
    /// </summary>
    public class SimbaRptAdgroupbaseGetResponse : TopResponse
    {
        /// <summary>
        /// 广告组基础数据对象
        /// </summary>
        [XmlElement("rpt_adgroup_base_list")]
        public string RptAdgroupBaseList { get; set; }
    }
}
