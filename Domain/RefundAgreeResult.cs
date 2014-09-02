using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// RefundAgreeResult Data Structure.
    /// </summary>
    [Serializable]
    public class RefundAgreeResult : TopObject
    {
        /// <summary>
        /// 消息码
        /// </summary>
        [XmlElement("code")]
        public long Code { get; set; }

        /// <summary>
        /// 退款结果
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 退款
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 退款id号
        /// </summary>
        [XmlElement("refund_id")]
        public long RefundId { get; set; }
    }
}
