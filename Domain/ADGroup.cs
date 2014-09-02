using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ADGroup Data Structure.
    /// </summary>
    [Serializable]
    public class ADGroup : TopObject
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
        /// 商品类目id，从根类目到子类目，用空格分割
        /// </summary>
        [XmlElement("category_ids")]
        public string CategoryIds { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 默认出价，单位为分，不能小于5
        /// </summary>
        [XmlElement("default_price")]
        public long DefaultPrice { get; set; }

        /// <summary>
        /// 非搜索是否使用默认出价，false-不用；true-使用；默认为true;
        /// </summary>
        [XmlElement("is_nonsearch_default_price")]
        public bool IsNonsearchDefaultPrice { get; set; }

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
        /// 非搜索出价，单位为分，不能小于5
        /// </summary>
        [XmlElement("nonsearch_max_price")]
        public long NonsearchMaxPrice { get; set; }

        /// <summary>
        /// 通投状态,1：开启；0：暂停；默认为1
        /// </summary>
        [XmlElement("nonsearch_status")]
        public long NonsearchStatus { get; set; }

        /// <summary>
        /// 商品数字id
        /// </summary>
        [XmlElement("num_iid")]
        public long NumIid { get; set; }

        /// <summary>
        /// online-上线；audit_offline-审核下线；crm_offline-CRM下线；默认为online
        /// </summary>
        [XmlElement("offline_type")]
        public string OfflineType { get; set; }

        /// <summary>
        /// 用户设置的上下线状态，offline-下线(暂停竞价)；online-上线；默认为online
        /// </summary>
        [XmlElement("online_status")]
        public string OnlineStatus { get; set; }

        /// <summary>
        /// 审核下线原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
