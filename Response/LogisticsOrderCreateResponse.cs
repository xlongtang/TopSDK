using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// LogisticsOrderCreateResponse.
    /// </summary>
    public class LogisticsOrderCreateResponse : TopResponse
    {
        /// <summary>
        /// 淘宝物流订单交易号，如返回-1则表示错误。如果在新建订单时传入trade_id,此处会返回此id，如果未传入trade_id，此处会返回淘宝物流分配的交易号码。
        /// </summary>
        [XmlElement("trade_id")]
        public long TradeId { get; set; }
    }
}
