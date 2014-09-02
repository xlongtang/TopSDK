using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// FeedDetail Data Structure.
    /// </summary>
    [Serializable]
    public class FeedDetail : TopObject
    {
        /// <summary>
        /// 评论的数量
        /// </summary>
        [XmlElement("comment_count")]
        public long CommentCount { get; set; }

        /// <summary>
        /// 如果是插件feed，指插件id
        /// </summary>
        [XmlElement("component_id")]
        public long ComponentId { get; set; }

        /// <summary>
        /// 如果是插件feed，指插件名
        /// </summary>
        [XmlElement("component_name")]
        public string ComponentName { get; set; }

        /// <summary>
        /// feed的封面区域 feedTile里的type=cover
        /// </summary>
        [XmlElement("cover_tile")]
        public FeedTile CoverTile { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        [XmlElement("deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        /// 如果是插件Feed,对应的详情地址
        /// </summary>
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 赞的数量
        /// </summary>
        [XmlElement("feedfavour_count")]
        public long FeedfavourCount { get; set; }

        /// <summary>
        /// feed的Id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 如果是插件Feed,对应插件的信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// feed的内容区域，type=text 或者type=pic ,type=picItem的目前不提供
        /// </summary>
        [XmlArray("tiles")]
        [XmlArrayItem("feed_tile")]
        public List<FeedTile> Tiles { get; set; }

        /// <summary>
        /// feed的发布时间
        /// </summary>
        [XmlElement("time")]
        public long Time { get; set; }

        /// <summary>
        /// feed的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
