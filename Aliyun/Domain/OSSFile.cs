using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// OSSFile Data Structure.
    /// </summary>
    [Serializable]
    public class OSSFile : TopObject
    {
        /// <summary>
        /// OSS bucket名称
        /// </summary>
        [XmlElement("Bucket")]
        public string Bucket { get; set; }

        /// <summary>
        /// oss 数据中心
        /// </summary>
        [XmlElement("Location")]
        public string Location { get; set; }

        /// <summary>
        /// OSS 文件对象名称
        /// </summary>
        [XmlElement("Object")]
        public string Object { get; set; }
    }
}
