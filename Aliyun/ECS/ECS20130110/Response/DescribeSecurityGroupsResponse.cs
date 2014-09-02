using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20130110.Response
{
    /// <summary>
    /// DescribeSecurityGroupsResponse.
    /// </summary>
    public class DescribeSecurityGroupsResponse : AliyunResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [XmlElement("PageNumber")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 每页行数
        /// </summary>
        [XmlElement("PageSize")]
        public long PageSize { get; set; }

        /// <summary>
        /// 安全组所属地域Id
        /// </summary>
        [XmlElement("RegionId")]
        public string RegionId { get; set; }

        /// <summary>
        /// 请求的唯一ID，系统自动生成
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 安全组信息，由SecurityGroup组成的集合
        /// </summary>
        [XmlArray("SecurityGroups")]
        [XmlArrayItem("SecurityGroup")]
        public List<SecurityGroup> SecurityGroups { get; set; }

        /// <summary>
        /// 安全组的总数
        /// </summary>
        [XmlElement("TotalCount")]
        public long TotalCount { get; set; }
    }
}
