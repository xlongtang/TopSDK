using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TradeOrderskuUpdateResponse.
    /// </summary>
    public class TradeOrderskuUpdateResponse : TopResponse
    {
        /// <summary>
        /// 只返回oid和modified
        /// </summary>
        [XmlElement("order")]
        public Order Order { get; set; }
    }
}
