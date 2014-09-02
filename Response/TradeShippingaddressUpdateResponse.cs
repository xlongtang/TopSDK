using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TradeShippingaddressUpdateResponse.
    /// </summary>
    public class TradeShippingaddressUpdateResponse : TopResponse
    {
        /// <summary>
        /// 交易结构
        /// </summary>
        [XmlElement("trade")]
        public Trade Trade { get; set; }
    }
}
