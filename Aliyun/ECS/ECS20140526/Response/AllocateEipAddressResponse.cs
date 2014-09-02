using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// AllocateEipAddressResponse.
    /// </summary>
    public class AllocateEipAddressResponse : AliyunResponse
    {
        /// <summary>
        /// 申请Id，唯一标识这一次申请。
        /// </summary>
        [XmlElement("AllocationId")]
        public string AllocationId { get; set; }

        /// <summary>
        /// 分配的弹性IP地址
        /// </summary>
        [XmlElement("EipAddress")]
        public string EipAddress { get; set; }
    }
}
