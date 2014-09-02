using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaAdgroupsItemExistResponse.
    /// </summary>
    public class SimbaAdgroupsItemExistResponse : TopResponse
    {
        /// <summary>
        /// true表示已经被推广，false表示没有被推广
        /// </summary>
        [XmlElement("exist")]
        public bool Exist { get; set; }
    }
}
