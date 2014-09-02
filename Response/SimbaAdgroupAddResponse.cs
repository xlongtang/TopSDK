using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaAdgroupAddResponse.
    /// </summary>
    public class SimbaAdgroupAddResponse : TopResponse
    {
        /// <summary>
        /// 新增加的推广组
        /// </summary>
        [XmlElement("adgroup")]
        public ADGroup Adgroup { get; set; }
    }
}
