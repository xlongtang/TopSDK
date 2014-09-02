using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TicketItemProcessResult Data Structure.
    /// </summary>
    [Serializable]
    public class TicketItemProcessResult : TopObject
    {
        /// <summary>
        /// 商品操作流程是否被迫终止。  如果broken==false则表示成功发布商品，则通过item_id字段获取新生成商品id；  如果broken==true则表示发布商品遇到问题，则通过broken_reasons字段获取到失败原因。
        /// </summary>
        [XmlElement("broken")]
        public bool Broken { get; set; }

        /// <summary>
        /// 操作商品遇到的错误原因
        /// </summary>
        [XmlArray("broken_reasons")]
        [XmlArrayItem("string")]
        public List<string> BrokenReasons { get; set; }

        /// <summary>
        /// 成功操作的商品标识
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }
    }
}
