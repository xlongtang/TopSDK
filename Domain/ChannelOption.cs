using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ChannelOption Data Structure.
    /// </summary>
    [Serializable]
    public class ChannelOption : TopObject
    {
        /// <summary>
        /// 频道id
        /// </summary>
        [XmlElement("channel_id")]
        public long ChannelId { get; set; }

        /// <summary>
        /// 是否有非搜索流量，true：是；false：否；
        /// </summary>
        [XmlElement("is_nonsearch")]
        public bool IsNonsearch { get; set; }

        /// <summary>
        /// 是否有搜索流量，true：是；false：否；
        /// </summary>
        [XmlElement("is_search")]
        public bool IsSearch { get; set; }

        /// <summary>
        /// 频道名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 流量名称
        /// </summary>
        [XmlElement("traffic_name")]
        public string TrafficName { get; set; }

        /// <summary>
        /// 流量类型，taobao：淘宝站内；other：淘宝站外
        /// </summary>
        [XmlElement("traffic_type")]
        public string TrafficType { get; set; }
    }
}
