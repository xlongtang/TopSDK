using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Chatpeer Data Structure.
    /// </summary>
    [Serializable]
    public class Chatpeer : TopObject
    {
        /// <summary>
        /// 聊天日期
        /// </summary>
        [XmlElement("date")]
        public string Date { get; set; }

        /// <summary>
        /// 聊天对象用户ID：cntaobao+淘宝nick，例如cntaobaotest
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
