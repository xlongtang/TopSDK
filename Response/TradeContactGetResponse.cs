using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TradeContactGetResponse.
    /// </summary>
    public class TradeContactGetResponse : TopResponse
    {
        /// <summary>
        /// 单笔订单联系信息
        /// </summary>
        [XmlElement("contact")]
        public TradeContact Contact { get; set; }
    }
}
