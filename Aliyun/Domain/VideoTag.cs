using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// VideoTag Data Structure.
    /// </summary>
    [Serializable]
    public class VideoTag : TopObject
    {
        /// <summary>
        /// tag类型
        /// </summary>
        [XmlElement("TagName")]
        public string TagName { get; set; }
    }
}
