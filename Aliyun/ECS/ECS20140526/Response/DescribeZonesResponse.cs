using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20140526.Response
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
        /// zone info
        /// </summary>
        [XmlArray("Zones")]
        [XmlArrayItem("Zone")]
        public List<Zone> Zones { get; set; }
    }
}
