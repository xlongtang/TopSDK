using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbNotifyMessagePageGetResponse.
    /// </summary>
    public class WlbNotifyMessagePageGetResponse : TopResponse
    {
        /// <summary>
        /// 条件查询结果总数量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }

        /// <summary>
        /// 消息结果列表
        /// </summary>
        [XmlArray("wlb_messages")]
        [XmlArrayItem("wlb_message")]
        public List<WlbMessage> WlbMessages { get; set; }
    }
}
