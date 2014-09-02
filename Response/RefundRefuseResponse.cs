using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// RefundRefuseResponse.
    /// </summary>
    public class RefundRefuseResponse : TopResponse
    {
        /// <summary>
        /// 拒绝退款成功后，会返回Refund数据结构中的refund_id, status, modified字段
        /// </summary>
        [XmlElement("refund")]
        public Refund Refund { get; set; }
    }
}
