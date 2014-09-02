using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// AuctionPVPairDO Data Structure.
    /// </summary>
    [Serializable]
    public class AuctionPVPairDO : TopObject
    {
        /// <summary>
        /// 类目销售属性id
        /// </summary>
        [XmlElement("property_id")]
        public long PropertyId { get; set; }

        /// <summary>
        /// 类目属性名称
        /// </summary>
        [XmlElement("property_text")]
        public string PropertyText { get; set; }

        /// <summary>
        /// sku属性对状态值
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 类目属性值id
        /// </summary>
        [XmlElement("value_id")]
        public long ValueId { get; set; }

        /// <summary>
        /// 类目属性值名称
        /// </summary>
        [XmlElement("value_text")]
        public string ValueText { get; set; }
    }
}
