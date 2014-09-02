using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbInventoryDetailGetResponse.
    /// </summary>
    public class WlbInventoryDetailGetResponse : TopResponse
    {
        /// <summary>
        /// 库存详情列表
        /// </summary>
        [XmlArray("inventory_list")]
        [XmlArrayItem("wlb_inventory")]
        public List<WlbInventory> InventoryList { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }
    }
}
