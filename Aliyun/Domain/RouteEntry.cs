using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// RouteEntry Data Structure.
    /// </summary>
    [Serializable]
    public class RouteEntry : TopObject
    {
        /// <summary>
        /// 目标网段地址
        /// </summary>
        [XmlElement("DestinationCidrBlock")]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// 下一跳的实例ID
        /// </summary>
        [XmlElement("InstanceId")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 路由条目所在的虚拟路由器
        /// </summary>
        [XmlElement("RouteTableId")]
        public string RouteTableId { get; set; }

        /// <summary>
        /// 路由状态
        /// </summary>
        [XmlElement("Status")]
        public string Status { get; set; }

        /// <summary>
        /// 路由类型(system|sustom)
        /// </summary>
        [XmlElement("Type")]
        public string Type { get; set; }
    }
}
