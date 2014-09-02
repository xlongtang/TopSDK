using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TripJipiaoAgentOrderGetResponse.
    /// </summary>
    public class TripJipiaoAgentOrderGetResponse : TopResponse
    {
        /// <summary>
        /// 返回订单详细列表
        /// </summary>
        [XmlArray("orders")]
        [XmlArrayItem("at_order")]
        public List<AtOrder> Orders { get; set; }
    }
}
