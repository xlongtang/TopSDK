using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// DiscardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class DiscardInfo : TopObject
    {
        /// <summary>
        /// 丢弃消息的结束时间
        /// </summary>
        [XmlElement("end")]
        public long End { get; set; }

        /// <summary>
        /// 用户nick
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 丢弃消息的开始时间
        /// </summary>
        [XmlElement("start")]
        public long Start { get; set; }

        /// <summary>
        /// 非授权消息订阅的关键字，比如按商品编号订阅时，此值为num_iid
        /// </summary>
        [XmlElement("subscribe_key")]
        public string SubscribeKey { get; set; }

        /// <summary>
        /// 非授权消息订阅的值，比如按商品编号订阅时，此值为商品的具体编号
        /// </summary>
        [XmlElement("subscribe_value")]
        public string SubscribeValue { get; set; }

        /// <summary>
        /// 消息类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
