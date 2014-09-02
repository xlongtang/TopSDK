using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// Eip Data Structure.
    /// </summary>
    [Serializable]
    public class Eip : TopObject
    {
        /// <summary>
        /// 申请Id
        /// </summary>
        [XmlElement("AllocationId")]
        public string AllocationId { get; set; }

        /// <summary>
        /// 创建时间。按照ISO8601标准表示，并需要使用UTC时间。格式为：  YYYY-MM-DDThh:mmZ
        /// </summary>
        [XmlElement("AllocationTime")]
        public string AllocationTime { get; set; }

        /// <summary>
        /// 弹性IP地址的公网带宽限速，默认是5Mbps
        /// </summary>
        [XmlElement("Bandwidth")]
        public string Bandwidth { get; set; }

        /// <summary>
        /// 弹性IP地址当前绑定的实例，如果未绑定则值为空。
        /// </summary>
        [XmlElement("InstanceId")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 弹性IP的计费方式  PayByBandwidth | PayByTraffic两个值中的一个。预付费实例显示PayByBandwidth（按带宽计费）。  PayByTraffic：按流量计费
        /// </summary>
        [XmlElement("InternetChargeType")]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// 弹性IP地址
        /// </summary>
        [XmlElement("IpAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// OperationLocksType，如果没有被锁定则其子节点不出现。
        /// </summary>
        [XmlElement("OperationLocks")]
        public string OperationLocks { get; set; }

        /// <summary>
        /// 虚拟网络所在的地域
        /// </summary>
        [XmlElement("RegionId")]
        public string RegionId { get; set; }

        /// <summary>
        /// 虚拟网络状态，包括pending和Available两种
        /// </summary>
        [XmlElement("Status")]
        public string Status { get; set; }
    }
}
