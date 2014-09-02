using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// CampaignPlatform Data Structure.
    /// </summary>
    [Serializable]
    public class CampaignPlatform : TopObject
    {
        /// <summary>
        /// 推广计划ID
        /// </summary>
        [XmlElement("campaign_id")]
        public long CampaignId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 非搜索投放频道代码数组，频道代码必须是直通车非搜索类频道列表中的值。？
        /// </summary>
        [XmlArray("nonsearch_channels")]
        [XmlArrayItem("number")]
        public List<long> NonsearchChannels { get; set; }

        /// <summary>
        /// 溢价的百分比，必须是大于等于 1小于等于200的整数
        /// </summary>
        [XmlElement("outside_discount")]
        public long OutsideDiscount { get; set; }

        /// <summary>
        /// 搜索投放频道代码数组，频道代码必须是直通车搜索类频道列表中的值。
        /// </summary>
        [XmlArray("search_channels")]
        [XmlArrayItem("number")]
        public List<long> SearchChannels { get; set; }
    }
}
