using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TradeConfirmfeeGetResponse.
    /// </summary>
    public class TradeConfirmfeeGetResponse : TopResponse
    {
        /// <summary>
        /// 获取到的交易确认收货费用
        /// </summary>
        [XmlElement("trade_confirm_fee")]
        public TradeConfirmFee TradeConfirmFee { get; set; }
    }
}
