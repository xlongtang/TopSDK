using System;
using System.Xml.Serialization;
using Top.Api;
using System.Collections.Generic;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// Zone Data Structure.
    /// </summary>
    [Serializable]
    public class Zone : TopObject
    {
        /// <summary>
        /// 允许创建的资源类型
        /// </summary>
        [XmlArray("AvailableDiskCategories")]
        [XmlArrayItem("DiskCategories")]
        public List<DiskCategories> AvailableDiskCategories { get; set; }

        /// <summary>
        /// 允许创建的资源类型
        /// </summary>
        [XmlArray("AvailableResourceCreation")]
        [XmlArrayItem("ResourceTypes")]
        public List<ResourceTypes> AvailableResourceCreation { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        [XmlElement("LocalName")]
        public string LocalName { get; set; }

        /// <summary>
        /// 区域ID
        /// </summary>
        [XmlElement("ZoneId")]
        public string ZoneId { get; set; }
    }
}
