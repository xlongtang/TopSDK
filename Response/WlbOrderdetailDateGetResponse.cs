using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbOrderdetailDateGetResponse.
    /// </summary>
    public class WlbOrderdetailDateGetResponse : TopResponse
    {
        /// <summary>
        /// 物流宝详细订单
        /// </summary>
        [XmlArray("order_detail_list")]
        [XmlArrayItem("wlb_order_detail")]
        public List<WlbOrderDetail> OrderDetailList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
