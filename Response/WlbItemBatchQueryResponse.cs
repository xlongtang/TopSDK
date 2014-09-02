using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbItemBatchQueryResponse.
    /// </summary>
    public class WlbItemBatchQueryResponse : TopResponse
    {
        /// <summary>
        /// 商品库存及批次信息查询结果
        /// </summary>
        [XmlArray("item_inventory_batch_list")]
        [XmlArrayItem("wlb_item_batch_inventory")]
        public List<WlbItemBatchInventory> ItemInventoryBatchList { get; set; }

        /// <summary>
        /// 返回结果记录的数量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
