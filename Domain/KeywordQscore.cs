using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// KeywordQscore Data Structure.
    /// </summary>
    [Serializable]
    public class KeywordQscore : TopObject
    {
        /// <summary>
        /// 推广组id
        /// </summary>
        [XmlElement("adgroup_id")]
        public long AdgroupId { get; set; }

        /// <summary>
        /// 推广计划id
        /// </summary>
        [XmlElement("campaign_id")]
        public long CampaignId { get; set; }

        /// <summary>
        /// 关键词id
        /// </summary>
        [XmlElement("keyword_id")]
        public long KeywordId { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 质量得分
        /// </summary>
        [XmlElement("qscore")]
        public string Qscore { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [XmlElement("word")]
        public string Word { get; set; }
    }
}
