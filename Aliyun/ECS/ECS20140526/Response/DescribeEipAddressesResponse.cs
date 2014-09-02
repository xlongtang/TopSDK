using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// DescribeEipAddressesResponse.
    /// </summary>
    public class DescribeEipAddressesResponse : AliyunResponse
    {
        /// <summary>
        /// 弹性IP地址详情EipAddressType组成的集合
        /// </summary>
        [XmlArray("EipAddresses")]
        [XmlArrayItem("Eip")]
        public List<Eip> EipAddresses { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("PageNumber")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 当前分页包含多少条目
        /// </summary>
        [XmlElement("PageSize")]
        public long PageSize { get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 列表条条目数
        /// </summary>
        [XmlElement("TotalCount")]
        public long TotalCount { get; set; }
    }
}
