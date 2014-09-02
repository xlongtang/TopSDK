using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbInventorylogQueryResponse.
    /// </summary>
    public class WlbInventorylogQueryResponse : TopResponse
    {
        /// <summary>
        /// 库存变更记录列表
        /// </summary>
        [XmlArray("inventory_log_list")]
        [XmlArrayItem("wlb_item_inventory_log")]
        public List<WlbItemInventoryLog> InventoryLogList { get; set; }

        /// <summary>
        /// 记录数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
