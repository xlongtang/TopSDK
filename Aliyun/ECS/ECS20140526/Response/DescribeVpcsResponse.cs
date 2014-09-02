using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// DescribeVpcsResponse.
    /// </summary>
    public class DescribeVpcsResponse : AliyunResponse
    {
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

        /// <summary>
        /// 虚拟网络详情VpcSetType组成的集合
        /// </summary>
        [XmlArray("Vpcs")]
        [XmlArrayItem("Vpcs")]
        public List<Vpcs> Vpcs { get; set; }
    }
}
