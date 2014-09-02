using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// IdsModule Data Structure.
    /// </summary>
    [Serializable]
    public class IdsModule : TopObject
    {
        /// <summary>
        /// 宝贝描述规范化模块id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 宝贝描述规范化模块名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 0为自动打标；  1为人工打标；
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }
    }
}
