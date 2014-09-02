using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaAdgroupidsDeletedGetResponse.
    /// </summary>
    public class SimbaAdgroupidsDeletedGetResponse : TopResponse
    {
        /// <summary>
        /// 推广组ID列表
        /// </summary>
        [XmlArray("deleted_adgroup_ids")]
        [XmlArrayItem("number")]
        public List<long> DeletedAdgroupIds { get; set; }
    }
}
