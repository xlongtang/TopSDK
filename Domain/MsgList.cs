using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// MsgList Data Structure.
    /// </summary>
    [Serializable]
    public class MsgList : TopObject
    {
        /// <summary>
        /// 当direction=0有效，完整消息内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 表示消息方向  0:from_id->to_id  1:to_id->from_id
        /// </summary>
        [XmlElement("direction")]
        public long Direction { get; set; }

        /// <summary>
        /// 当direction=1有效，消息长度
        /// </summary>
        [XmlElement("length")]
        public long Length { get; set; }

        /// <summary>
        /// 东八区时间
        /// </summary>
        [XmlElement("time")]
        public string Time { get; set; }

        /// <summary>
        /// type & 1  ：自动回复  type & 2  : 陌生人消息（等于0是好友消息）  type & 4  : 广播消息  type & 8  : 最近联系人陌生人消息  type & 16 : 离线消息  type & 32 : 子账号转发系统消息
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }

        /// <summary>
        /// 当direction=1有效，url列表
        /// </summary>
        [XmlArray("url_lists")]
        [XmlArrayItem("url_list")]
        public List<UrlList> UrlLists { get; set; }

        /// <summary>
        /// 当direction=1有效，（关键词，数量）列表
        /// </summary>
        [XmlArray("word_lists")]
        [XmlArrayItem("word_count_list")]
        public List<WordCountList> WordLists { get; set; }
    }
}
