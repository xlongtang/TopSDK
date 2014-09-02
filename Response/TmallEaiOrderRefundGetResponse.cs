using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallEaiOrderRefundGetResponse.
    /// </summary>
    public class TmallEaiOrderRefundGetResponse : TopResponse
    {
        /// <summary>
        /// 退款单
        /// </summary>
        [XmlElement("refund_bill")]
        public RefundBill RefundBill { get; set; }
    }
}
