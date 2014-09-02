using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TradeWaimaiOrdersGetResponse.
    /// </summary>
    public class TradeWaimaiOrdersGetResponse : TopResponse
    {
        /// <summary>
        /// 查询到的订单列表对象
        /// </summary>
        [XmlElement("result")]
        public ListResult Result { get; set; }
    }
}
