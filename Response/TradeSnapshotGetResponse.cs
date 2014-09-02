using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TradeSnapshotGetResponse.
    /// </summary>
    public class TradeSnapshotGetResponse : TopResponse
    {
        /// <summary>
        /// 只包含Trade中的tid和snapshot、子订单Order中的oid和snapshot
        /// </summary>
        [XmlElement("trade")]
        public Trade Trade { get; set; }
    }
}
