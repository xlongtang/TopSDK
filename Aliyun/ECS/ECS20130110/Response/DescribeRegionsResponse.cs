using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20130110.Response
{
    /// <summary>
    /// DescribeRegionsResponse.
    /// </summary>
    public class DescribeRegionsResponse : AliyunResponse
    {
        /// <summary>
        /// 地域信息组成的集合
        /// </summary>
        [XmlArray("Regions")]
        [XmlArrayItem("Region")]
        public List<Region> Regions { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
