using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WeitaoFeedAddResponse.
    /// </summary>
    public class WeitaoFeedAddResponse : TopResponse
    {
        /// <summary>
        /// 发布feed成功后返回的feedId
        /// </summary>
        [XmlElement("feed_id")]
        public long FeedId { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
