using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TradeReceivetimeDelayResponse.
    /// </summary>
    public class TradeReceivetimeDelayResponse : TopResponse
    {
        /// <summary>
        /// 更新后的交易数据，只包括tid和modified两个字段。
        /// </summary>
        [XmlElement("trade")]
        public Trade Trade { get; set; }
    }
}
