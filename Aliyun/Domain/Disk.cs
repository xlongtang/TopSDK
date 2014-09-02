using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// Disk Data Structure.
    /// </summary>
    [Serializable]
    public class Disk : TopObject
    {
        /// <summary>
        /// 挂载时间。按照ISO8601标准表示，并需要使用UTC时间。格式为：  YYYY-MM-DDThh:mmZ  只有在Status为In_use时才有意义
        /// </summary>
        [XmlElement("AttachedTime")]
        public string AttachedTime { get; set; }

        /// <summary>
        /// 磁盘种类  可选值：cloud: 云磁盘，ephemeral: 临时磁盘
        /// </summary>
        [XmlElement("Category")]
        public string Category { get; set; }

        /// <summary>
        /// 创建时间。按照ISO8601标准表示，并需要使用UTC时间。格式为：  YYYY-MM-DDThh:mmZ
        /// </summary>
        [XmlElement("CreationTime")]
        public string CreationTime { get; set; }

        /// <summary>
        /// 是否同时删除自动快照，true|false。  通过CreateSnapshot或者在控制台创建的快照，不受这个参数的影响，始终会被保留。
        /// </summary>
        [XmlElement("DeleteAutoSnapshot")]
        public string DeleteAutoSnapshot { get; set; }

        /// <summary>
        /// True表示Instance释放时，这块磁盘随Instance一起释放；false表示Instance释放时，这块磁盘保留不释放。
        /// </summary>
        [XmlElement("DeleteWithInstance")]
        public string DeleteWithInstance { get; set; }

        /// <summary>
        /// 磁盘描述
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 卸载时间。按照ISO8601标准表示，并需要使用UTC时间。格式为：  YYYY-MM-DDThh:mmZ  只有在Status为Available时才有意义
        /// </summary>
        [XmlElement("DetachedTime")]
        public string DetachedTime { get; set; }

        /// <summary>
        /// 所属Instance的Device信息：比如/dev/xvdb  只有在Status为In_use是才有值，其他状态为空。
        /// </summary>
        [XmlElement("Device")]
        public string Device { get; set; }

        /// <summary>
        /// 磁盘ID
        /// </summary>
        [XmlElement("DiskId")]
        public string DiskId { get; set; }

        /// <summary>
        /// 磁盘名
        /// </summary>
        [XmlElement("DiskName")]
        public string DiskName { get; set; }

        /// <summary>
        /// 创建磁盘的镜像ID，只有通过镜像创建的磁盘才有值，否则为空。这个值在磁盘的生命周期内始终不变
        /// </summary>
        [XmlElement("ImageId")]
        public string ImageId { get; set; }

        /// <summary>
        /// 所属Instance ID  只有在Status为In_use时才有值，其他状态为空。
        /// </summary>
        [XmlElement("InstanceId")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 磁盘锁定原因类型
        /// </summary>
        [XmlElement("OperationLocks")]
        public string OperationLocks { get; set; }

        /// <summary>
        /// True代表是独立云磁盘，可以独立存在且可以自由在可用区内挂载和下载，false代表非独立云磁盘，只能和实例同生同灭。用户如果需要做attach和detach操作，必须先查询一下这个属性为true的磁盘才能操作。临时磁盘，云磁盘的系统盘和包月的云磁盘，该属性都为false。这个属性用户不能更改。
        /// </summary>
        [XmlElement("Portable")]
        public string Portable { get; set; }

        /// <summary>
        /// 镜像市场的商品标识
        /// </summary>
        [XmlElement("ProductCode")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 磁盘所属的地域 ID
        /// </summary>
        [XmlElement("RegionId")]
        public string RegionId { get; set; }

        /// <summary>
        /// 磁盘大小，单位GB
        /// </summary>
        [XmlElement("Size")]
        public long Size { get; set; }

        /// <summary>
        /// 创建磁盘使用的快照，如果创建磁盘时，没有指定快照，则为空。这个值在磁盘的生命周期内始终不变。
        /// </summary>
        [XmlElement("SourceSnapshotId")]
        public string SourceSnapshotId { get; set; }

        /// <summary>
        /// 磁盘状态  In_use|Available|Attaching|Detaching|Creating|ReIniting
        /// </summary>
        [XmlElement("Status")]
        public string Status { get; set; }

        /// <summary>
        /// 磁盘类型  可选值：system: 系统盘，data: 数据盘
        /// </summary>
        [XmlElement("Type")]
        public string Type { get; set; }

        /// <summary>
        /// 磁盘所属的可用区ID
        /// </summary>
        [XmlElement("ZoneId")]
        public string ZoneId { get; set; }
    }
}
