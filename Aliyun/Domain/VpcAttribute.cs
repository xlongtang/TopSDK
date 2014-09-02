using System;
using System.Xml.Serialization;
using Top.Api;
using System.Collections.Generic;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// VpcAttribute Data Structure.
    /// </summary>
    [Serializable]
    public class VpcAttribute : TopObject
    {
        /// <summary>
        /// 云产品Ip，用于云产品之间的网络互通
        /// </summary>
        [XmlElement("NatIpAddress")]
        public string NatIpAddress { get; set; }

        /// <summary>
        /// vpc内网IP地址列表
        /// </summary>
        [XmlArray("PrivateIpAddress")]
        [XmlArrayItem("IpAddress")]
        public List<IpAddress> PrivateIpAddress { get; set; }

        /// <summary>
        /// 虚拟交换机Id
        /// </summary>
        [XmlElement("VSwitchId")]
        public string VSwitchId { get; set; }

        /// <summary>
        /// 虚拟专有网络Id
        /// </summary>
        [XmlElement("VpcId")]
        public string VpcId { get; set; }
    }
}
