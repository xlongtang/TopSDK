using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Campaign Data Structure.
    /// </summary>
    [Serializable]
    public class Campaign : TopObject
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
        /// 用户设置的上下限状态；offline-下线；online-上线；
        /// </summary>
        [XmlElement("online_status")]
        public string OnlineStatus { get; set; }

        /// <summary>
        /// 推广计划结算下线原因，1-余额不足；2-超过日限额，以分号分隔多个下线原因
        /// </summary>
        [XmlElement("settle_reason")]
        public string SettleReason { get; set; }

        /// <summary>
        /// 推广计划结算状态，offline-下线；online-上线，
        /// </summary>
        [XmlElement("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 推广计划名称，不能多余20个汉字
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
