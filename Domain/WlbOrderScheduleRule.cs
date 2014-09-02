using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbOrderScheduleRule Data Structure.
    /// </summary>
    [Serializable]
    public class WlbOrderScheduleRule : TopObject
    {
        /// <summary>
        /// 收货地址范围: 6位数的地址ID，用逗号分隔。如“140400,230500”。同一个卖家的订单调度规则中，设置的收货地址范围不能重复。
        /// </summary>
        [XmlElement("area_ids")]
        public string AreaIds { get; set; }

        /// <summary>
        /// 备用配送中心ID
        /// </summary>
        [XmlElement("backup_store_id")]
        public long BackupStoreId { get; set; }

        /// <summary>
        /// 默认配送中心ID
        /// </summary>
        [XmlElement("default_store_id")]
        public long DefaultStoreId { get; set; }

        /// <summary>
        /// 订单调度规则ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 发货规则的额外规则设置： 允许组合，用逗号隔开.  REMARK_STOP--有订单留言不自动下发;  COD_STOP--货到付款订单不自动下发;  CHECK_WAREHOUSE_DELIVER--检查仓库的配送范围
        /// </summary>
        [XmlElement("options")]
        public string Options { get; set; }

        /// <summary>
        /// 预售配送中心ID（预留，暂未使用）
        /// </summary>
        [XmlElement("presell_store_id")]
        public long PresellStoreId { get; set; }

        /// <summary>
        /// wlb_base_rule表的ID
        /// </summary>
        [XmlElement("rule_id")]
        public long RuleId { get; set; }

        /// <summary>
        /// 商家userId
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 商品userNick
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }
    }
}
