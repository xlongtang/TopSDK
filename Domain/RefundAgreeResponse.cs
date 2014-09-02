using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// RefundAgreeResponse Data Structure.
    /// </summary>
    [Serializable]
    public class RefundAgreeResponse : TopObject
    {
        /// <summary>
        /// 退款结果消息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 消息编码
        /// </summary>
        [XmlElement("msg_code")]
        public string MsgCode { get; set; }

        /// <summary>
        /// 退款中每个退款操作的结果信息
        /// </summary>
        [XmlArray("results")]
        [XmlArrayItem("refund_mapping_result")]
        public List<RefundMappingResult> Results { get; set; }

        /// <summary>
        /// 退款整体是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
