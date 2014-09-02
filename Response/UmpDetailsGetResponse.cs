using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpDetailsGetResponse.
    /// </summary>
    public class UmpDetailsGetResponse : TopResponse
    {
        /// <summary>
        /// 活动详情的信息
        /// </summary>
        [XmlArray("contents")]
        [XmlArrayItem("string")]
        public List<string> Contents { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
