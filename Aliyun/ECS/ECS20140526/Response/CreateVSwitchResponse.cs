using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// CreateVSwitchResponse.
    /// </summary>
    public class CreateVSwitchResponse : AliyunResponse
    {
        /// <summary>
        /// RequestId
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 系统分配的虚拟网络 ID
        /// </summary>
        [XmlElement("VSwitchId")]
        public string VSwitchId { get; set; }
    }
}
