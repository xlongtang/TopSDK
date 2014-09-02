using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbOrderstatusGetResponse.
    /// </summary>
    public class WlbOrderstatusGetResponse : TopResponse
    {
        /// <summary>
        /// 订单流转信息状态列表
        /// </summary>
        [XmlArray("wlb_order_status")]
        [XmlArrayItem("wlb_process_status")]
        public List<WlbProcessStatus> WlbOrderStatus { get; set; }
    }
}
