using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbTmsorderQueryResponse.
    /// </summary>
    public class WlbTmsorderQueryResponse : TopResponse
    {
        /// <summary>
        /// 物流订单运单信息列表
        /// </summary>
        [XmlArray("tms_order_list")]
        [XmlArrayItem("wlb_tms_order")]
        public List<WlbTmsOrder> TmsOrderList { get; set; }

        /// <summary>
        /// 结果总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
