using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// CampaignBudget Data Structure.
    /// </summary>
    [Serializable]
    public class CampaignBudget : TopObject
    {
        /// <summary>
        /// 日限额，单位是元，不得小于30
        /// </summary>
        [XmlElement("budget")]
        public long Budget { get; set; }

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
        /// 是否平滑消耗，true-是；false-否；在设置了推广计划日限额后，此属性才生效
        /// </summary>
        [XmlElement("is_smooth")]
        public bool IsSmooth { get; set; }

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
    }
}
