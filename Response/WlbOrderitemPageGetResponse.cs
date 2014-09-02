using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbOrderitemPageGetResponse.
    /// </summary>
    public class WlbOrderitemPageGetResponse : TopResponse
    {
        /// <summary>
        /// 物流宝订单商品列表
        /// </summary>
        [XmlArray("order_item_list")]
        [XmlArrayItem("wlb_order_item")]
        public List<WlbOrderItem> OrderItemList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
