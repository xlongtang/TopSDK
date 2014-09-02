using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TraderateAddResponse.
    /// </summary>
    public class TraderateAddResponse : TopResponse
    {
        /// <summary>
        /// 返回tid、oid、create
        /// </summary>
        [XmlElement("trade_rate")]
        public TradeRate TradeRate { get; set; }
    }
}
