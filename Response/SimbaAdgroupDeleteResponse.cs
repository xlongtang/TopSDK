using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaAdgroupDeleteResponse.
    /// </summary>
    public class SimbaAdgroupDeleteResponse : TopResponse
    {
        /// <summary>
        /// 被删除的推广组
        /// </summary>
        [XmlElement("adgroup")]
        public ADGroup Adgroup { get; set; }
    }
}
