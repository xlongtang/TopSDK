using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// DescribeInstanceAttributeResponse.
    /// </summary>
    public class DescribeInstanceAttributeResponse : AliyunResponse
    {
        /// <summary>
        /// 集群Id
        /// </summary>
        [XmlElement("ClusterId")]
        public string ClusterId { get; set; }

        /// <summary>
        /// 创建时间。按照ISO8601标准表示，并需要使用UTC时间。格式为：  YYYY-MM-DDThh:mmZ
        /// </summary>
        [XmlElement("CreationTime")]
        public string CreationTime { get; set; }

        /// <summary>
        /// 实例的描述
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 实例绑定的EIP信息
        /// </summary>
        [XmlElement("EipAddress")]
        public EipAddressAssignType EipAddress { get; set; }

        /// <summary>
        /// 实例机器名称
        /// </summary>
        [XmlElement("HostName")]
        public string HostName { get; set; }

        /// <summary>
        /// 镜像ID
        /// </summary>
        [XmlElement("ImageId")]
        public string ImageId { get; set; }

        /// <summary>
        /// 实例的内网IP地址
        /// </summary>
        [XmlArray("InnerIpAddress")]
        [XmlArrayItem("IpAddress")]
        public List<IpAddress> InnerIpAddress { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [XmlElement("InstanceId")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例的显示名称
        /// </summary>
        [XmlElement("InstanceName")]
        public string InstanceName { get; set; }

        /// <summary>
        /// 实例网络类型，可选值classic | vpc
        /// </summary>
        [XmlElement("InstanceNetworkType")]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// 实例资源规格
        /// </summary>
        [XmlElement("InstanceType")]
        public string InstanceType { get; set; }

        /// <summary>
        /// 网络计费类型，PayByBandwidth | PayByTraffic两个值中的一个。预付费实例显示PayByBandwidth（按带宽计费）。  PayByTraffic：按流量计费  PayByBandwidth：按带宽计费
        /// </summary>
        [XmlElement("InternetChargeType")]
        public string InternetChargeType { get; set; }

        /// <summary>
        /// 公网入带宽最大值
        /// </summary>
        [XmlElement("InternetMaxBandwidthIn")]
        public long InternetMaxBandwidthIn { get; set; }

        /// <summary>
        /// 公网出带宽最大值
        /// </summary>
        [XmlElement("InternetMaxBandwidthOut")]
        public long InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// 锁定原因类型列表
        /// </summary>
        [XmlArray("OperationLocks")]
        [XmlArrayItem("LockReason")]
        public List<LockReason> OperationLocks { get; set; }

        /// <summary>
        /// 实例的公网IP地址
        /// </summary>
        [XmlArray("PublicIpAddress")]
        [XmlArrayItem("IpAddress")]
        public List<IpAddress> PublicIpAddress { get; set; }

        /// <summary>
        /// 实例所属地域ID
        /// </summary>
        [XmlElement("RegionId")]
        public string RegionId { get; set; }

        /// <summary>
        /// 请求的唯一ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 实例所属安全组的集合
        /// </summary>
        [XmlArray("SecurityGroupIds")]
        [XmlArrayItem("SecurityGroupId")]
        public List<SecurityGroupId> SecurityGroupIds { get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [XmlElement("Status")]
        public string Status { get; set; }

        /// <summary>
        /// 虚拟局域网ID
        /// </summary>
        [XmlElement("VlanId")]
        public string VlanId { get; set; }

        /// <summary>
        /// 实例的VPC信息
        /// </summary>
        [XmlElement("VpcAttributes")]
        public VpcAttribute VpcAttributes { get; set; }

        /// <summary>
        /// 云服务器所属于的可用区
        /// </summary>
        [XmlElement("ZoneId")]
        public string ZoneId { get; set; }
    }
}
