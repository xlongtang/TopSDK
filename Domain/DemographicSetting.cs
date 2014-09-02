using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// DemographicSetting Data Structure.
    /// </summary>
    [Serializable]
    public class DemographicSetting : TopObject
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
        /// 投放人群ID
        /// </summary>
        [XmlElement("demographic_id")]
        public long DemographicId { get; set; }

        /// <summary>
        /// 加价
        /// </summary>
        [XmlElement("incremental_price")]
        public long IncrementalPrice { get; set; }

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
    }
}
