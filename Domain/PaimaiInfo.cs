using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// PaimaiInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PaimaiInfo : TopObject
    {
        /// <summary>
        /// 用户自定义的固定保证金。如果用户未传则说明用户选择使用淘宝默认的保证金模式10%，此时deposit等于0.
        /// </summary>
        [XmlElement("deposit")]
        public long Deposit { get; set; }

        /// <summary>
        /// 降价拍中的降价间隔
        /// </summary>
        [XmlElement("interval")]
        public long Interval { get; set; }

        /// <summary>
        /// 拍卖类型，目前包括增加拍，荷兰拍和降价拍。
        /// </summary>
        [XmlElement("mode")]
        public long Mode { get; set; }

        /// <summary>
        /// 降价拍的保留价
        /// </summary>
        [XmlElement("reserve")]
        public string Reserve { get; set; }

        /// <summary>
        /// 对于拍卖来说可以设定有效期，这里是有效期的小时数。
        /// </summary>
        [XmlElement("valid_hour")]
        public long ValidHour { get; set; }

        /// <summary>
        /// 对于拍卖来说可以设定有效期，这里是有效期的分钟数。
        /// </summary>
        [XmlElement("valid_minute")]
        public long ValidMinute { get; set; }
    }
}
