using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20130110.Response
{
    /// <summary>
    /// DeleteImageResponse.
    /// </summary>
    public class DeleteImageResponse : AliyunResponse
    {
        /// <summary>
        /// 请求的唯一ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
