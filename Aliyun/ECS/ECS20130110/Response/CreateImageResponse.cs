using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20130110.Response
{
    /// <summary>
    /// CreateImageResponse.
    /// </summary>
    public class CreateImageResponse : AliyunResponse
    {
        /// <summary>
        /// 镜像ID
        /// </summary>
        [XmlElement("ImageId")]
        public string ImageId { get; set; }

        /// <summary>
        /// 请求的唯一ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
