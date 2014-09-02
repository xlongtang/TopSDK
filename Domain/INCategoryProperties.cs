using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// INCategoryProperties Data Structure.
    /// </summary>
    [Serializable]
    public class INCategoryProperties : TopObject
    {
        /// <summary>
        /// 类目属性对象描述
        /// </summary>
        [XmlElement("properties_desc")]
        public string PropertiesDesc { get; set; }

        /// <summary>
        /// 类目属性对象ID
        /// </summary>
        [XmlElement("properties_id")]
        public long PropertiesId { get; set; }

        /// <summary>
        /// 类目属性名称
        /// </summary>
        [XmlElement("properties_name")]
        public string PropertiesName { get; set; }
    }
}
