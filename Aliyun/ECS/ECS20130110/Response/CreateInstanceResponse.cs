using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20130110.Response
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

        /// <summary>
        /// 云服务器所属于的可用区
        /// </summary>
        [XmlElement("ZoneId")]
        public string ZoneId { get; set; }
    }
}
