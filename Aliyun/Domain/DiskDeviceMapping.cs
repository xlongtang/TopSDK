using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// DiskDeviceMapping Data Structure.
    /// </summary>
    [Serializable]
    public class DiskDeviceMapping : TopObject
    {
        /// <summary>
        /// 生成磁盘的Device信息：比如/dev/xvdb
        /// </summary>
        [XmlElement("Device")]
        public string Device { get; set; }

        /// <summary>
        /// 生成磁盘的大小
        /// </summary>
        [XmlElement("Size")]
        public string Size { get; set; }

        /// <summary>
        /// 快照ID
        /// </summary>
        [XmlElement("SnapshotId")]
        public string SnapshotId { get; set; }
    }
}
