using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoRefundGetResponse.
    /// </summary>
    public class FenxiaoRefundGetResponse : TopResponse
    {
        /// <summary>
        /// 退款详情
        /// </summary>
        [XmlElement("refund_detail")]
        public RefundDetail RefundDetail { get; set; }
    }
}
