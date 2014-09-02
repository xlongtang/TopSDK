using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// DiskCategories Data Structure.
    /// </summary>
    [Serializable]
    public class DiskCategories : TopObject
    {
        /// <summary>
        /// 磁盘种类
        /// </summary>
        [XmlElement("DiskCategories")]
        public string DiskCategories_ { get; set; }
    }
}
