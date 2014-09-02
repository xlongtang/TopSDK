using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaAdgroupidsChangedGetResponse.
    /// </summary>
    public class SimbaAdgroupidsChangedGetResponse : TopResponse
    {
        /// <summary>
        /// 推广组ID列表
        /// </summary>
        [XmlArray("changed_adgroupids")]
        [XmlArrayItem("number")]
        public List<long> ChangedAdgroupids { get; set; }
    }
}
