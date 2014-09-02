using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// ModifyVRouterAttributeResponse.
    /// </summary>
    public class ModifyVRouterAttributeResponse : AliyunResponse
    {
        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
