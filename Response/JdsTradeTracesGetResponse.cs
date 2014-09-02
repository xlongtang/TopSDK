using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// JdsTradeTracesGetResponse.
    /// </summary>
    public class JdsTradeTracesGetResponse : TopResponse
    {
        /// <summary>
        /// 跟踪信息列表
        /// </summary>
        [XmlArray("traces")]
        [XmlArrayItem("trade_trace")]
        public List<TradeTrace> Traces { get; set; }
    }
}
