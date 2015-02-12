using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// RefundGetResponse.
    /// </summary>
    public class RefundGetResponse : TopResponse
    {
        /// <summary>
        /// 退款详情
        /// </summary>
        [XmlElement("refund")]
        public Refund Refund { get; set; }
    }
}
