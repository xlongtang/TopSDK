using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// CreateVpcResponse.
    /// </summary>
    public class CreateVpcResponse : AliyunResponse
    {
        /// <summary>
        /// 虚拟路由器默认路由表Id
        /// </summary>
        [XmlElement("RouteTableId")]
        public string RouteTableId { get; set; }

        /// <summary>
        /// 虚拟路由器Id
        /// </summary>
        [XmlElement("VRouterId")]
        public string VRouterId { get; set; }

        /// <summary>
        /// 系统分配的虚拟网络 ID
        /// </summary>
        [XmlElement("VpcId")]
        public string VpcId { get; set; }
    }
}
