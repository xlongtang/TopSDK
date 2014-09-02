using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// IpcInventoryDetailDo Data Structure.
    /// </summary>
    [Serializable]
    public class IpcInventoryDetailDo : TopObject
    {
        /// <summary>
        /// 主订单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public long BizOrderId { get; set; }

        /// <summary>
        /// 子订单号
        /// </summary>
        [XmlElement("biz_sub_order_id")]
        public long BizSubOrderId { get; set; }

        /// <summary>
        /// 1拍减 2付减
        /// </summary>
        [XmlElement("flag")]
        public long Flag { get; set; }

        /// <summary>
        /// 占用数量
        /// </summary>
        [XmlElement("occupy_quantity")]
        public long OccupyQuantity { get; set; }

        /// <summary>
        /// 货主昵称
        /// </summary>
        [XmlElement("owner_nick")]
        public string OwnerNick { get; set; }

        /// <summary>
        /// 预扣库存数
        /// </summary>
        [XmlElement("reserve_quantity")]
        public long ReserveQuantity { get; set; }

        /// <summary>
        /// 仓储商品id
        /// </summary>
        [XmlElement("sc_item_id")]
        public long ScItemId { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
