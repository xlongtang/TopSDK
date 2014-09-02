using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// EipAddressAssignType Data Structure.
    /// </summary>
    [Serializable]
    public class EipAddressAssignType : TopObject
    {
        /// <summary>
        /// 申请Id
        /// </summary>
        [XmlElement("AllocationId")]
        public string AllocationId { get; set; }

        /// <summary>
        /// 弹性IP地址的公网带宽限速，默认是5Mbps
        /// </summary>
        [XmlElement("Bandwidth")]
        public long Bandwidth { get; set; }

        /// <summary>
        /// 弹性IP的计费方式。
        /// </summary>
        [XmlElement("InternetChargeType")]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// 弹性IP地址
        /// </summary>
        [XmlElement("IpAddress")]
        public string IpAddress { get; set; }
    }
}
