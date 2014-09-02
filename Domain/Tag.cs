using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Tag Data Structure.
    /// </summary>
    [Serializable]
    public class Tag : TopObject
    {
        /// <summary>
        /// 标签key
        /// </summary>
        [XmlElement("tag_key")]
        public string TagKey { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }

        /// <summary>
        /// 签标类型
        /// </summary>
        [XmlElement("tag_type")]
        public string TagType { get; set; }
    }
}
