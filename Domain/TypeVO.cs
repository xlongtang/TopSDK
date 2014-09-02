using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TypeVO Data Structure.
    /// </summary>
    [Serializable]
    public class TypeVO : TopObject
    {
        /// <summary>
        /// 描述信息
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 唯一标识
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 类型名称 唯一标识
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
