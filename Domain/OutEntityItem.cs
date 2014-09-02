using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// OutEntityItem Data Structure.
    /// </summary>
    [Serializable]
    public class OutEntityItem : TopObject
    {
        /// <summary>
        /// entity_type对应的实体类型的id：  当entity_type为IC_ITEM时，entity_id为ic的商品id
        /// </summary>
        [XmlElement("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 外部实体类型：  IC_ITEM--ic商品  IC_SKU--ic销售单元
        /// </summary>
        [XmlElement("entity_type")]
        public string EntityType { get; set; }
    }
}
