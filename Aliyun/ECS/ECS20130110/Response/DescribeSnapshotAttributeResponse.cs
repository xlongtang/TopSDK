using System;
using System.Xml.Serialization;
using Aliyun.Api;

namespace Aliyun.Api.ECS.ECS20130110.Response
{
    /// <summary>
    /// DescribeSnapshotAttributeResponse.
    /// </summary>
    public class DescribeSnapshotAttributeResponse : AliyunResponse
    {
        /// <summary>
        /// 快照创建时间。按照ISO8601标准表示，并需要使用UTC时间。格式为：  YYYY-MM-DDThh:mmZ
        /// </summary>
        [XmlElement("CreationTime")]
        public string CreationTime { get; set; }

        /// <summary>
        /// 创建进度，单位为百分比，100表示创建完成
        /// </summary>
        [XmlElement("Progress")]
        public string Progress { get; set; }

        /// <summary>
        /// 请求的唯一ID
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 快照标识编码
        /// </summary>
        [XmlElement("SnapshotId")]
        public string SnapshotId { get; set; }

        /// <summary>
        /// 快照显示名称。如果创建时指定了快照显示名称，则返回指定的名称
        /// </summary>
        [XmlElement("SnapshotName")]
        public string SnapshotName { get; set; }
    }
}
