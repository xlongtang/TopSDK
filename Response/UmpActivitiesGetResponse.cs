using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpActivitiesGetResponse.
    /// </summary>
    public class UmpActivitiesGetResponse : TopResponse
    {
        /// <summary>
        /// 营销活动内容，可以通过ump sdk来进行处理
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
