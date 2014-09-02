using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// InnerLabel Data Structure.
    /// </summary>
    [Serializable]
    public class InnerLabel : TopObject
    {
        /// <summary>
        /// 标签的Id
        /// </summary>
        [XmlElement("label_id")]
        public long LabelId { get; set; }

        /// <summary>
        /// 标签在分组中的优先级，0最高、1次之
        /// </summary>
        [XmlElement("level")]
        public long Level { get; set; }
    }
}
