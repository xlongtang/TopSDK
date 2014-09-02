using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20130110.Response
{
    /// <summary>
    /// RevokeSecurityGroupResponse.
    /// </summary>
    public class RevokeSecurityGroupResponse : AliyunResponse
    {
        /// <summary>
        /// 请求的ID,作为请求的唯一编号
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
