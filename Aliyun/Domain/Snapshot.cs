using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// Snapshot Data Structure.
    /// </summary>
    [Serializable]
    public class Snapshot : TopObject
    {
        /// <summary>
        /// 快照创建时间
        /// </summary>
        [XmlElement("CreationTime")]
        public string CreationTime { get; set; }

        /// <summary>
        /// 快照说明
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 从镜像市场继承的产品编号
        /// </summary>
        [XmlElement("ProductCode")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 快照完成进度
        /// </summary>
        [XmlElement("Progress")]
        public string Progress { get; set; }

        /// <summary>
        /// 快照ID
        /// </summary>
        [XmlElement("SnapshotId")]
        public string SnapshotId { get; set; }

        /// <summary>
        /// 快照名称
        /// </summary>
        [XmlElement("SnapshotName")]
        public string SnapshotName { get; set; }

        /// <summary>
        /// 创建快照的磁盘id
        /// </summary>
        [XmlElement("SourceDiskId")]
        public string SourceDiskId { get; set; }

        /// <summary>
        /// 创建快照的磁盘大小
        /// </summary>
        [XmlElement("SourceDiskSize")]
        public long SourceDiskSize { get; set; }

        /// <summary>
        /// 创建快照的磁盘种类
        /// </summary>
        [XmlElement("SourceDiskType")]
        public string SourceDiskType { get; set; }
    }
}
