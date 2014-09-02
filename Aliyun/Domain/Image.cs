using System;
using System.Xml.Serialization;
using Top.Api;
using System.Collections.Generic;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// Image Data Structure.
    /// </summary>
    [Serializable]
    public class Image : TopObject
    {
        /// <summary>
        /// 操作系统位数
        /// </summary>
        [XmlElement("Architecture")]
        public string Architecture { get; set; }

        /// <summary>
        /// 创建时间。按照ISO8601标准表示，并需要使用UTC时间。格式为：  YYYY-MM-DDThh:mmZ
        /// </summary>
        [XmlElement("CreationTime")]
        public string CreationTime { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 镜像下包含磁盘和快照的系统描述
        /// </summary>
        [XmlArray("DiskDeviceMappings")]
        [XmlArrayItem("DiskDeviceMapping")]
        public List<DiskDeviceMapping> DiskDeviceMappings { get; set; }

        /// <summary>
        /// 镜像ID
        /// </summary>
        [XmlElement("ImageId")]
        public string ImageId { get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [XmlElement("ImageName")]
        public string ImageName { get; set; }

        /// <summary>
        /// 镜像所有者
        /// </summary>
        [XmlElement("ImageOwnerAlias")]
        public string ImageOwnerAlias { get; set; }

        /// <summary>
        /// 镜像版本
        /// </summary>
        [XmlElement("ImageVersion")]
        public string ImageVersion { get; set; }

        /// <summary>
        /// 用户是否订阅了该镜像的ProductCode对应的镜像商品的服务条款. True：表示已经订阅  False：表示未订阅
        /// </summary>
        [XmlElement("IsSubscribed")]
        public string IsSubscribed { get; set; }

        /// <summary>
        /// 操作系统名称
        /// </summary>
        [XmlElement("OSName")]
        public string OSName { get; set; }

        /// <summary>
        /// 平台
        /// </summary>
        [XmlElement("Platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 镜像市场的镜像商品标示
        /// </summary>
        [XmlElement("ProductCode")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 大小
        /// </summary>
        [XmlElement("Size")]
        public long Size { get; set; }

        /// <summary>
        /// 可见性
        /// </summary>
        [XmlElement("Visibility")]
        public string Visibility { get; set; }
    }
}
