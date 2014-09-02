using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WeitaoFeedIsrelationResponse.
    /// </summary>
    public class WeitaoFeedIsrelationResponse : TopResponse
    {
        /// <summary>
        /// 是否关注
        /// </summary>
        [XmlElement("result")]
        public long Result { get; set; }
    }
}
