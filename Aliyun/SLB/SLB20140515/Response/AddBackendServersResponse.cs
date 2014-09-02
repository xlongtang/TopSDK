using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.SLB.SLB20140515.Response
{
    /// <summary>
    /// AddBackendServersResponse.
    /// </summary>
    public class AddBackendServersResponse : AliyunResponse
    {
        /// <summary>
        /// SLB内多个后端服务器的信息
        /// </summary>
        [XmlArray("BackendServers")]
        [XmlArrayItem("BackendServer")]
        public List<BackendServer> BackendServers { get; set; }

        /// <summary>
        /// SLB实例的唯一标识。
        /// </summary>
        [XmlElement("LoadBalancerId")]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// 请求的唯一号
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
