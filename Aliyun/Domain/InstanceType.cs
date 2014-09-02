using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// InstanceType Data Structure.
    /// </summary>
    [Serializable]
    public class InstanceType : TopObject
    {
        /// <summary>
        /// CPU的内核数目
        /// </summary>
        [XmlElement("CpuCoreCount")]
        public long CpuCoreCount { get; set; }

        /// <summary>
        /// 实例规格的ID
        /// </summary>
        [XmlElement("InstanceTypeId")]
        public string InstanceTypeId { get; set; }

        /// <summary>
        /// 内存大小，单位GB
        /// </summary>
        [XmlElement("MemorySize")]
        public string MemorySize { get; set; }
    }
}
