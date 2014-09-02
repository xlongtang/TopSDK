using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbItemInventory Data Structure.
    /// </summary>
    [Serializable]
    public class WlbItemInventory : TopObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 锁定库存数量
        /// </summary>
        [XmlElement("lock_quantity")]
        public long LockQuantity { get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [XmlElement("store_code")]
        public string StoreCode { get; set; }

        /// <summary>
        /// SELLALBE 可销售库存  DEFECTIVE 残次  JISHUN 机损  XIANGSHUN 箱损  FREEZE 冻结库存  ONROAD 在途库存
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
