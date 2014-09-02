using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WeitaoFeedGetResponse.
    /// </summary>
    public class WeitaoFeedGetResponse : TopResponse
    {
        /// <summary>
        /// feed的详细信息
        /// </summary>
        [XmlElement("feed_detail")]
        public FeedDetail FeedDetail { get; set; }

        /// <summary>
        /// 接口执行是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }
    }
}
