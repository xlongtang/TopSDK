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
        /// 创意得分
        /// </summary>
        [XmlElement("creative_score")]
        public string CreativeScore { get; set; }

        /// <summary>
        /// 基础分
        /// </summary>
        [XmlElement("cust_score")]
        public string CustScore { get; set; }

        /// <summary>
        /// 买家体验分
        /// </summary>
        [XmlElement("cvr_score")]
        public string CvrScore { get; set; }

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
        /// 质量总分
        /// </summary>
        [XmlElement("qscore")]
        public string Qscore { get; set; }

        /// <summary>
        /// 相关性
        /// </summary>
        [XmlElement("rele_score")]
        public string ReleScore { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [XmlElement("word")]
        public string Word { get; set; }
    }
}
