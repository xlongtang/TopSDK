using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WeitaoFeedsGetResponse.
    /// </summary>
    public class WeitaoFeedsGetResponse : TopResponse
    {
        /// <summary>
        /// 返回的feed列表
        /// </summary>
        [XmlArray("feed_list")]
        [XmlArrayItem("simple_feed")]
        public List<SimpleFeed> FeedList { get; set; }

        /// <summary>
        /// 接口执行是否成功
        /// </summary>
        [XmlElement("result")]
        public bool Result { get; set; }

        /// <summary>
        /// feed的总记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
