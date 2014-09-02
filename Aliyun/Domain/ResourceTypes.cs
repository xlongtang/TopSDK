using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// ResourceTypes Data Structure.
    /// </summary>
    [Serializable]
    public class ResourceTypes : TopObject
    {
        /// <summary>
        /// 资源类型
        /// </summary>
        [XmlElement("ResourceTypes")]
        public string ResourceTypes_ { get; set; }
    }
}
