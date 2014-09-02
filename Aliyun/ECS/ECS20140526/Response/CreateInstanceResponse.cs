using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// CreateInstanceResponse.
    /// </summary>
    public class CreateInstanceResponse : AliyunResponse
    {
        /// <summary>
        /// 实例ID
        /// </summary>
        [XmlElement("InstanceId")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
