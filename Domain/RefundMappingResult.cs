using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// RefundMappingResult Data Structure.
    /// </summary>
    [Serializable]
    public class RefundMappingResult : TopObject
    {
        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 退款ID
        /// </summary>
        [XmlElement("refund_id")]
        public long RefundId { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("succ")]
        public bool Succ { get; set; }
    }
}
