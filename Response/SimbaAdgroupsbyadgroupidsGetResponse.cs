using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaAdgroupsbyadgroupidsGetResponse.
    /// </summary>
    public class SimbaAdgroupsbyadgroupidsGetResponse : TopResponse
    {
        /// <summary>
        /// 返回的推广组分页对象
        /// </summary>
        [XmlElement("adgroups")]
        public ADGroupPage Adgroups { get; set; }
    }
}
