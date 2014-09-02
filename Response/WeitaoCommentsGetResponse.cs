using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WeitaoCommentsGetResponse.
    /// </summary>
    public class WeitaoCommentsGetResponse : TopResponse
    {
        /// <summary>
        /// 评论列表
        /// </summary>
        [XmlArray("comment_list")]
        [XmlArrayItem("feed_comment")]
        public List<FeedComment> CommentList { get; set; }

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
