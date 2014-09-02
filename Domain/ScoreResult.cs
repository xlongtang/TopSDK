using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ScoreResult Data Structure.
    /// </summary>
    [Serializable]
    public class ScoreResult : TopObject
    {
        /// <summary>
        /// 服务态度评分
        /// </summary>
        [XmlElement("attitude_score")]
        public string AttitudeScore { get; set; }

        /// <summary>
        /// 平均分
        /// </summary>
        [XmlElement("avg_score")]
        public string AvgScore { get; set; }

        /// <summary>
        /// 易用性评分
        /// </summary>
        [XmlElement("easyuse_score")]
        public string EasyuseScore { get; set; }

        /// <summary>
        /// 评价时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 评价id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 是否实际付费 1-实际付费 2-实际未付费
        /// </summary>
        [XmlElement("is_pay")]
        public long IsPay { get; set; }

        /// <summary>
        /// 是否为有效评分 1-有效评分 2-无效评分
        /// </summary>
        [XmlElement("is_valid")]
        public long IsValid { get; set; }

        /// <summary>
        /// 服务规格code
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 服务规格名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 描述相符
        /// </summary>
        [XmlElement("matched_score")]
        public string MatchedScore { get; set; }

        /// <summary>
        /// 专业性评分
        /// </summary>
        [XmlElement("prof_score")]
        public string ProfScore { get; set; }

        /// <summary>
        /// 交片速度
        /// </summary>
        [XmlElement("rapid_score")]
        public string RapidScore { get; set; }

        /// <summary>
        /// 服务code
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 稳定性评分
        /// </summary>
        [XmlElement("stability_score")]
        public string StabilityScore { get; set; }

        /// <summary>
        /// 评论内容
        /// </summary>
        [XmlElement("suggestion")]
        public string Suggestion { get; set; }

        /// <summary>
        /// 评价人用户昵称
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }
    }
}
