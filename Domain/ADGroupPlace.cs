using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ADGroupPlace Data Structure.
    /// </summary>
    [Serializable]
    public class ADGroupPlace : TopObject
    {
        /// <summary>
        /// 推广组ID
        /// </summary>
        [XmlElement("adgroup_id")]
        public long AdgroupId { get; set; }

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
        /// 是否使用默认出价，0-不用；1-使用；
        /// </summary>
        [XmlElement("is_default_price")]
        public long IsDefaultPrice { get; set; }

        /// <summary>
        /// 出价
        /// </summary>
        [XmlElement("max_price")]
        public long MaxPrice { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 位置标识
        /// </summary>
        [XmlElement("place_id")]
        public long PlaceId { get; set; }

        /// <summary>
        /// 位置名称
        /// </summary>
        [XmlElement("place_name")]
        public string PlaceName { get; set; }
    }
}
