using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20130110.Response
{
    /// <summary>
    /// DescribeZonesResponse.
    /// </summary>
    public class DescribeZonesResponse : AliyunResponse
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 可用区域列表
        /// </summary>
        [XmlArray("Zones")]
        [XmlArrayItem("Zone")]
        public List<Zone> Zones { get; set; }
    }
}
