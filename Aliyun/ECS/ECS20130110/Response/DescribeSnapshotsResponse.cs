using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20130110.Response
{
    /// <summary>
    /// DescribeSnapshotsResponse.
    /// </summary>
    public class DescribeSnapshotsResponse : AliyunResponse
    {
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
    }
}
