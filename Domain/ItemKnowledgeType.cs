using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ItemKnowledgeType Data Structure.
    /// </summary>
    [Serializable]
    public class ItemKnowledgeType : TopObject
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 类型描述
        /// </summary>
        [XmlElement("type_desc")]
        public string TypeDesc { get; set; }

        /// <summary>
        /// 问题类型
        /// </summary>
        [XmlElement("type_key")]
        public string TypeKey { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        [XmlElement("type_name")]
        public string TypeName { get; set; }
    }
}
