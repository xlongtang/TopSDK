using System;
using System.Xml.Serialization;
using Aliyun.Api;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20140526.Response
{
    /// <summary>
    /// DescribeAutoSnapshotPolicyResponse.
    /// </summary>
    public class DescribeAutoSnapshotPolicyResponse : AliyunResponse
    {
        /// <summary>
        /// 自动快照策略的执行情况
        /// </summary>
        [XmlElement("AutoSnapshotExcutionStatus")]
        public AutoSnapshotExecutionStatusType AutoSnapshotExcutionStatus { get; set; }

        /// <summary>
        /// 自动快照策略详情
        /// </summary>
        [XmlElement("AutoSnapshotPolicy")]
        public AutoSnapshotPolicyType AutoSnapshotPolicy { get; set; }
    }
}
