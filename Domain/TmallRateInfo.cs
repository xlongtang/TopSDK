using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TmallRateInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TmallRateInfo : TopObject
    {
        /// <summary>
        /// 追加评价内容
        /// </summary>
        [XmlElement("append_content")]
        public string AppendContent { get; set; }

        /// <summary>
        /// 追评中是否含有负向标签
        /// </summary>
        [XmlElement("append_has_negtv")]
        public bool AppendHasNegtv { get; set; }

        /// <summary>
        /// 追加评价中带有的语义标签列表
        /// </summary>
        [XmlArray("append_tags")]
        [XmlArrayItem("tmall_rate_tag")]
        public List<TmallRateTag> AppendTags { get; set; }

        /// <summary>
        /// 追加评价时间
        /// </summary>
        [XmlElement("append_time")]
        public string AppendTime { get; set; }

        /// <summary>
        /// 评价时间
        /// </summary>
        [XmlElement("comment_time")]
        public string CommentTime { get; set; }

        /// <summary>
        /// 评价内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 原始评价是否含有负向标签
        /// </summary>
        [XmlElement("has_negtv")]
        public bool HasNegtv { get; set; }

        /// <summary>
        /// 原始评价对应的标签列表
        /// </summary>
        [XmlArray("tags")]
        [XmlArrayItem("tmall_rate_tag")]
        public List<TmallRateTag> Tags { get; set; }

        /// <summary>
        /// 表示评价者的昵称
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }
    }
}
