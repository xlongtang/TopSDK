using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaAdgroupsChangedGetResponse.
    /// </summary>
    public class SimbaAdgroupsChangedGetResponse : TopResponse
    {
        /// <summary>
        /// 推广组分页对象
        /// </summary>
        [XmlElement("adgroups")]
        public ADGroupPage Adgroups { get; set; }
    }
}
