using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ErrorMessage Data Structure.
    /// </summary>
    [Serializable]
    public class ErrorMessage : TopObject
    {
        /// <summary>
        /// 买家昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 发送失败的原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
