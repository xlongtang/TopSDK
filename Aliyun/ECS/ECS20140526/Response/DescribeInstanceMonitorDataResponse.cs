using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// DescribeInstanceMonitorDataResponse.
    /// </summary>
    public class DescribeInstanceMonitorDataResponse : AliyunResponse
    {
        /// <summary>
        /// 实例的监控数据InstanceMonitorData组成的集合。
        /// </summary>
        [XmlArray("MonitorData")]
        [XmlArrayItem("InstanceMonitorData")]
        public List<InstanceMonitorData> MonitorData { get; set; }

        /// <summary>
        /// 请求的唯一ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
