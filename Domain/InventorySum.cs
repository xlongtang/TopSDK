using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// InventorySum Data Structure.
    /// </summary>
    [Serializable]
    public class InventorySum : TopObject
    {
        /// <summary>
        /// 库存类型：  1：正常   2：损坏   3：冻结   10：质押   11-20:商家自定义
        /// </summary>
        [XmlElement("inventory_type")]
        public long InventoryType { get; set; }

        /// <summary>
        /// 库存类型名称
        /// </summary>
        [XmlElement("inventory_type_name")]
        public string InventoryTypeName { get; set; }

        /// <summary>
        /// 总占用数量
        /// </summary>
        [XmlElement("occupy_quantity")]
        public long OccupyQuantity { get; set; }

        /// <summary>
        /// 总物理库存数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 总预扣数量
        /// </summary>
        [XmlElement("reserve_quantity")]
        public long ReserveQuantity { get; set; }

        /// <summary>
        /// 商品商家编码
        /// </summary>
        [XmlElement("sc_item_code")]
        public string ScItemCode { get; set; }

        /// <summary>
        /// 商品后端ID，如果有传sc_item_code,参数可以为0
        /// </summary>
        [XmlElement("sc_item_id")]
        public long ScItemId { get; set; }

        /// <summary>
        /// 商家仓库编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }
    }
}
