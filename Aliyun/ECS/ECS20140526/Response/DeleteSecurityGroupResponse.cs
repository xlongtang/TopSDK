using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// DeleteSecurityGroupResponse.
    /// </summary>
    public class DeleteSecurityGroupResponse : AliyunResponse
    {
        /// <summary>
        /// 请求的唯一ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
