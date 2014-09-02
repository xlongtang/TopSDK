using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// FeedComment Data Structure.
    /// </summary>
    [Serializable]
    public class FeedComment : TopObject
    {
        /// <summary>
        /// 评论内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 评论的扩展数据，json格式，目前支持图片与宝贝,type=1时格式：["http://gw3.alicdn.com/tfscom/tuitui/i2/11659032089367711/T1mhfOFiJiXXb1upjX.jpg"]，type=2时格式见示例。
        /// </summary>
        [XmlElement("ext_symbol")]
        public string ExtSymbol { get; set; }

        /// <summary>
        /// 评论所属的feed的Id
        /// </summary>
        [XmlElement("feed_id")]
        public long FeedId { get; set; }

        /// <summary>
        /// 评论楼层
        /// </summary>
        [XmlElement("floor")]
        public long Floor { get; set; }

        /// <summary>
        /// 评论ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 评论发布的时间
        /// </summary>
        [XmlElement("time")]
        public long Time { get; set; }

        /// <summary>
        /// 评论类型,0纯文本，1含有图片，2含有宝贝
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
