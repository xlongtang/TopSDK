using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbOrderItem Data Structure.
    /// </summary>
    [Serializable]
    public class WlbOrderItem : TopObject
    {
        /// <summary>
        /// 批次号备注
        /// </summary>
        [XmlElement("batch_remark")]
        public string BatchRemark { get; set; }

        /// <summary>
        /// 物流宝订单确认状态：  NO_NEED_CONFIRM--不需要确认  WAIT_CONFIRM--待确认  CONFIRMED--已确认
        /// </summary>
        [XmlElement("confirm_status")]
        public string ConfirmStatus { get; set; }

        /// <summary>
        /// 外部实体id
        /// </summary>
        [XmlElement("ext_entity_id")]
        public string ExtEntityId { get; set; }

        /// <summary>
        /// 外部实体类型
        /// </summary>
        [XmlElement("ext_entity_type")]
        public string ExtEntityType { get; set; }

        /// <summary>
        /// 第一位标示是否为赠品
        /// </summary>
        [XmlElement("flag")]
        public long Flag { get; set; }

        /// <summary>
        /// 订单商品id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// INVENTORY_TYPE_SELL 可销库存  INVENTORY_TYPE_IMPERFECTIONS 残次库存  INVENTORY_TYPE_FREEZE 冻结库存  INVENTORY_TYPE_ON_PASSAGE 在途库存  INVENTORY_TYPE_ENGINE_DAMAGE 机损  INVENTORY_TYPE_BOX_DAMAGE 箱损
        /// </summary>
        [XmlElement("inventory_type")]
        public string InventoryType { get; set; }

        /// <summary>
        /// 订单商品编码
        /// </summary>
        [XmlElement("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 物流宝订单商品的物流宝商品id
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 订单商品名称
        /// </summary>
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [XmlElement("item_price")]
        public long ItemPrice { get; set; }

        /// <summary>
        /// 物流宝订单编码
        /// </summary>
        [XmlElement("order_code")]
        public string OrderCode { get; set; }

        /// <summary>
        /// 物流宝订单id
        /// </summary>
        [XmlElement("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// 子交易号
        /// </summary>
        [XmlElement("order_sub_2code")]
        public string OrderSub2code { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("order_sub_code")]
        public string OrderSubCode { get; set; }

        /// <summary>
        /// (1)其它: OTHER (2)淘宝交易: TAOBAO (3)调拨: ALLOCATION (4)盘点:CHECK (5)销售采购:PRUCHASE(6)其它交易：OTHER_TRADE
        /// </summary>
        [XmlElement("order_sub_type")]
        public string OrderSubType { get; set; }

        /// <summary>
        /// 订单商品图片url
        /// </summary>
        [XmlElement("picture_url")]
        public string PictureUrl { get; set; }

        /// <summary>
        /// 计划数量
        /// </summary>
        [XmlElement("plan_quantity")]
        public long PlanQuantity { get; set; }

        /// <summary>
        /// 货主id
        /// </summary>
        [XmlElement("provider_tp_id")]
        public long ProviderTpId { get; set; }

        /// <summary>
        /// 货主nick
        /// </summary>
        [XmlElement("provider_tp_nick")]
        public string ProviderTpNick { get; set; }

        /// <summary>
        /// 商品发布版本号
        /// </summary>
        [XmlElement("publish_version")]
        public long PublishVersion { get; set; }

        /// <summary>
        /// 实际数量
        /// </summary>
        [XmlElement("real_quantity")]
        public long RealQuantity { get; set; }

        /// <summary>
        /// 订单商品备注
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 订单商品用户id
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }

        /// <summary>
        /// 订单商品用户昵称
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }
    }
}
