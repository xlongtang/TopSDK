using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// DescribeSnapshotsResponse.
    /// </summary>
    public class DescribeSnapshotsResponse : AliyunResponse
    {
        /// <summary>
        /// 实例列表的页码
        /// </summary>
        [XmlElement("PageNumber")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 输入时设置的每页行数
        /// </summary>
        [XmlElement("PageSize")]
        public long PageSize { get; set; }

        /// <summary>
        /// 镜像所属地域Id
        /// </summary>
        [XmlElement("RegionId")]
        public string RegionId { get; set; }

        /// <summary>
        /// 请求的唯一ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 快照详情列表
        /// </summary>
        [XmlArray("Snapshots")]
        [XmlArrayItem("Snapshot")]
        public List<Snapshot> Snapshots { get; set; }

        /// <summary>
        /// 实例总个数
        /// </summary>
        [XmlElement("TotalCount")]
        public long TotalCount { get; set; }
    }
}
