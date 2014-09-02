using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Subscription Data Structure.
    /// </summary>
    [Serializable]
    public class Subscription : TopObject
    {
        /// <summary>
        /// 增量消息的状态（隶属于主题）。具体选值请见：商品消息状态、退款消息状态、交易消息状态中的说明。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 增量消息所属的主题。  可选值   trade（交易类型）   item（商品类型）   refund（退款类型）
        /// </summary>
        [XmlElement("topic")]
        public string Topic { get; set; }
    }
}
