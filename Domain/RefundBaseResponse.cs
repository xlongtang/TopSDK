using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// RefundBaseResponse Data Structure.
    /// </summary>
    [Serializable]
    public class RefundBaseResponse : TopObject
    {
        /// <summary>
        /// 返回的信息，包括成功和失败的具体信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 返回的信息编号
        /// </summary>
        [XmlElement("msg_code")]
        public long MsgCode { get; set; }

        /// <summary>
        /// 指示操作是否成功
        /// </summary>
        [XmlElement("success")]
        public bool Success { get; set; }
    }
}
