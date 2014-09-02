using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbItemBatchInventory Data Structure.
    /// </summary>
    [Serializable]
    public class WlbItemBatchInventory : TopObject
    {
        /// <summary>
        /// 批次库存查询结果
        /// </summary>
        [XmlArray("item_batch")]
        [XmlArrayItem("wlb_item_batch")]
        public List<WlbItemBatch> ItemBatch { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 商品库存查询结果
        /// </summary>
        [XmlArray("item_inventorys")]
        [XmlArrayItem("wlb_item_inventory")]
        public List<WlbItemInventory> ItemInventorys { get; set; }

        /// <summary>
        /// 商品在所有仓库的可销库存总数
        /// </summary>
        [XmlElement("total_quantity")]
        public long TotalQuantity { get; set; }
    }
}
