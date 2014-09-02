using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20130110.Response
{
    /// <summary>
    /// DescribeInstanceDisksResponse.
    /// </summary>
    public class DescribeInstanceDisksResponse : AliyunResponse
    {
        /// <summary>
        /// 磁盘信息组成的集合
        /// </summary>
        [XmlArray("Disks")]
        [XmlArrayItem("Disk")]
        public List<Disk> Disks { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }
    }
}
