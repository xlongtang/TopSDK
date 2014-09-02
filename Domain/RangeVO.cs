using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// RangeVO Data Structure.
    /// </summary>
    [Serializable]
    public class RangeVO : TopObject
    {
        /// <summary>
        /// 描述信息
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 档案唯一标识
        /// </summary>
        [XmlElement("document_id")]
        public long DocumentId { get; set; }

        /// <summary>
        /// 唯一标识
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 值域的范围 Key
        /// </summary>
        [XmlElement("key")]
        public string Key { get; set; }

        /// <summary>
        /// 取值范围的value字段
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
