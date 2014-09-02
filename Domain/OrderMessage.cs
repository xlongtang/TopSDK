using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// OrderMessage Data Structure.
    /// </summary>
    [Serializable]
    public class OrderMessage : TopObject
    {
        /// <summary>
        /// 留言内容
        /// </summary>
        [XmlElement("message_content")]
        public string MessageContent { get; set; }

        /// <summary>
        /// 留言时间
        /// </summary>
        [XmlElement("message_time")]
        public string MessageTime { get; set; }

        /// <summary>
        /// 留言标题，例如：分销商留言，供应商留言，买家留言
        /// </summary>
        [XmlElement("message_title")]
        public string MessageTitle { get; set; }

        /// <summary>
        /// 留言时的图片地址
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }
    }
}
