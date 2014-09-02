using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20130110.Response
{
    /// <summary>
    /// AllocatePublicIpAddressResponse.
    /// </summary>
    public class AllocatePublicIpAddressResponse : AliyunResponse
    {
        /// <summary>
        /// 分配的公网IP地址。
        /// </summary>
        [XmlElement("IpAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
