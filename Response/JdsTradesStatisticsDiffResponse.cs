using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// JdsTradesStatisticsDiffResponse.
    /// </summary>
    public class JdsTradesStatisticsDiffResponse : TopResponse
    {
        /// <summary>
        /// pre_status比post_status多的tid列表
        /// </summary>
        [XmlArray("tids")]
        [XmlArrayItem("number")]
        public List<long> Tids { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
