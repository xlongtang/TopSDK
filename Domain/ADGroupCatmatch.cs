using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ADGroupCatmatch Data Structure.
    /// </summary>
    [Serializable]
    public class ADGroupCatmatch : TopObject
    {
        /// <summary>
        /// 推广组id
        /// </summary>
        [XmlElement("adgroup_id")]
        public long AdgroupId { get; set; }

        /// <summary>
        /// 推广计划Id
        /// </summary>
        [XmlElement("campaign_id")]
        public long CampaignId { get; set; }

        /// <summary>
        /// 类目出价Id
        /// </summary>
        [XmlElement("catmatch_id")]
        public long CatmatchId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 是否使用推广组默认出价，false-不使用默认出价  true-使用默认出价；默认true
        /// </summary>
        [XmlElement("is_default_price")]
        public bool IsDefaultPrice { get; set; }

        /// <summary>
        /// 类目出价，单位为分，不能小于5
        /// </summary>
        [XmlElement("max_price")]
        public long MaxPrice { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 推广组主人昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 是否启用类目出价；offline-不启用；online-启用；默认启用
        /// </summary>
        [XmlElement("online_status")]
        public string OnlineStatus { get; set; }

        /// <summary>
        /// 类目出价质量得分
        /// </summary>
        [XmlElement("qscore")]
        public string Qscore { get; set; }
    }
}
