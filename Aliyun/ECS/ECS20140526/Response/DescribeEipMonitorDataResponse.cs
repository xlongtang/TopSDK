using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// DescribeEipMonitorDataResponse.
    /// </summary>
    public class DescribeEipMonitorDataResponse : AliyunResponse
    {
        /// <summary>
        /// 实例的监控数据EipMonitorDataType数据集合
        /// </summary>
        [XmlArray("EipMonitorDatas")]
        [XmlArrayItem("EipMonitorData")]
        public List<EipMonitorData> EipMonitorDatas { get; set; }

        /// <summary>
        /// 请求的唯一ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
