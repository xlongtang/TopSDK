using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// DescribeRouteTablesResponse.
    /// </summary>
    public class DescribeRouteTablesResponse : AliyunResponse
    {
        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("PageNumber")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [XmlElement("PageSize")]
        public long PageSize { get; set; }

        /// <summary>
        /// 请求id
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 路由表
        /// </summary>
        [XmlArray("RouteTables")]
        [XmlArrayItem("RouteTable")]
        public List<RouteTable> RouteTables { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("TotalCount")]
        public long TotalCount { get; set; }
    }
}
