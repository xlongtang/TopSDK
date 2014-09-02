using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// DdTopAuctionRuleVO Data Structure.
    /// </summary>
    [Serializable]
    public class DdTopAuctionRuleVO : TopObject
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("day_ends")]
        public long DayEnds { get; set; }

        /// <summary>
        /// 每天的开始时间， 格式：10000*hh+100*mm+ss
        /// </summary>
        [XmlElement("day_starts")]
        public long DayStarts { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        [XmlElement("features")]
        public string Features { get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 是否是到店
        /// </summary>
        [XmlElement("is_diandian")]
        public bool IsDiandian { get; set; }

        /// <summary>
        /// 是否是外卖
        /// </summary>
        [XmlElement("is_takeout")]
        public bool IsTakeout { get; set; }

        /// <summary>
        /// 规则名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 规则结束时间
        /// </summary>
        [XmlElement("rule_ends")]
        public string RuleEnds { get; set; }

        /// <summary>
        /// 规则开始时间
        /// </summary>
        [XmlElement("rule_starts")]
        public string RuleStarts { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 商铺ID
        /// </summary>
        [XmlElement("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 周期轮询0,1,2,3通过逗号间隔
        /// </summary>
        [XmlElement("weeklys")]
        public string Weeklys { get; set; }
    }
}
