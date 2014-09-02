using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaAdgroupCampcatmatchsGetResponse.
    /// </summary>
    public class SimbaAdgroupCampcatmatchsGetResponse : TopResponse
    {
        /// <summary>
        /// 一页推广组类目出价列表
        /// </summary>
        [XmlElement("adgroupcatmatchs")]
        public ADGroupCatMatchPage Adgroupcatmatchs { get; set; }
    }
}
