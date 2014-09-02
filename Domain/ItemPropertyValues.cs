using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// ItemPropertyValues Data Structure.
    /// </summary>
    [Serializable]
    public class ItemPropertyValues : TopObject
    {
        /// <summary>
        /// 服务属性id
        /// </summary>
        [XmlElement("property_id")]
        public long PropertyId { get; set; }

        /// <summary>
        /// 属性名称
        /// </summary>
        [XmlElement("property_name")]
        public string PropertyName { get; set; }

        /// <summary>
        /// 属性值列表.
        /// </summary>
        [XmlArray("property_values")]
        [XmlArrayItem("string")]
        public List<string> PropertyValues { get; set; }
    }
}
