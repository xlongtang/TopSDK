using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// CreateSecurityGroupResponse.
    /// </summary>
    public class CreateSecurityGroupResponse : AliyunResponse
    {
        /// <summary>
        /// 请求的唯一ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 安全组ID
        /// </summary>
        [XmlElement("SecurityGroupId")]
        public string SecurityGroupId { get; set; }
    }
}
