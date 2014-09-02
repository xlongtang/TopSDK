using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TmcMessage Data Structure.
    /// </summary>
    [Serializable]
    public class TmcMessage : TopObject
    {
        /// <summary>
        /// 消息详细内容，格式为JSON/XML
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 消息ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 消息发布者的AppKey
        /// </summary>
        [XmlElement("pub_app_key")]
        public string PubAppKey { get; set; }

        /// <summary>
        /// 消息发布时间
        /// </summary>
        [XmlElement("pub_time")]
        public string PubTime { get; set; }

        /// <summary>
        /// 消息所属主题
        /// </summary>
        [XmlElement("topic")]
        public string Topic { get; set; }

        /// <summary>
        /// 消息所属的用户编号
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 用户的昵称
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }
    }
}
