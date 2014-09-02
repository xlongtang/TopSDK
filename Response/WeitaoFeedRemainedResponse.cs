using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WeitaoFeedRemainedResponse.
    /// </summary>
    public class WeitaoFeedRemainedResponse : TopResponse
    {
        /// <summary>
        /// 今天还能发送多少条Feed
        /// </summary>
        [XmlElement("remained_count")]
        public long RemainedCount { get; set; }

        /// <summary>
        /// 今天发送的Feed的数目
        /// </summary>
        [XmlElement("send_count")]
        public long SendCount { get; set; }
    }
}
