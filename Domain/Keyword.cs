using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Keyword Data Structure.
    /// </summary>
    [Serializable]
    public class Keyword : TopObject
    {
        /// <summary>
        /// 推广组id
        /// </summary>
        [XmlElement("adgroup_id")]
        public long AdgroupId { get; set; }

        /// <summary>
        /// 审核拒绝原因描述
        /// </summary>
        [XmlElement("audit_desc")]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 审核状态：   audit_wait-待审核；  audit_pass-审核通过(上线)；  audit_reject-审核拒绝；  audit_offline-审核直接下线；  默认为 audit_pass。
        /// </summary>
        [XmlElement("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 推广计划id
        /// </summary>
        [XmlElement("campaign_id")]
        public long CampaignId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 是否使用推广组默认出价，true-是；false-否；
        /// </summary>
        [XmlElement("is_default_price")]
        public bool IsDefaultPrice { get; set; }

        /// <summary>
        /// 是否是垃圾词，false-不是；true-是；垃圾词是近期无点击的词
        /// </summary>
        [XmlElement("is_garbage")]
        public bool IsGarbage { get; set; }

        /// <summary>
        /// 关键词id
        /// </summary>
        [XmlElement("keyword_id")]
        public long KeywordId { get; set; }

        /// <summary>
        /// 匹配模式
        /// </summary>
        [XmlElement("match_scope")]
        public string MatchScope { get; set; }

        /// <summary>
        /// 关键词出价，单位为分，不能小于5
        /// </summary>
        [XmlElement("max_price")]
        public long MaxPrice { get; set; }

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
        /// 词质量得分
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
