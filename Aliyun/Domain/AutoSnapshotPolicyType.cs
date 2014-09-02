using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// AutoSnapshotPolicyType Data Structure.
    /// </summary>
    [Serializable]
    public class AutoSnapshotPolicyType : TopObject
    {
        /// <summary>
        /// 数据盘自动快照策略的开关：  True：数据盘执行自动快照策略  False：数据盘不执行自动快照策略
        /// </summary>
        [XmlElement("DataDiskPolicyEnabled")]
        public string DataDiskPolicyEnabled { get; set; }

        /// <summary>
        /// 保留自动快照的天数， 1|2|3
        /// </summary>
        [XmlElement("DataDiskPolicyRetentionDays")]
        public long DataDiskPolicyRetentionDays { get; set; }

        /// <summary>
        /// 数据盘自动快照策略的保留上周日选项：  True：代表保留上周日的快照  False：不保留
        /// </summary>
        [XmlElement("DataDiskPolicyRetentionLastWeek")]
        public string DataDiskPolicyRetentionLastWeek { get; set; }

        /// <summary>
        /// 数据盘自动快照策略的保留天数：  4个时间段，  1：1:00-7:00  2：7:00-13:00  3：13:00-19:00  4：19:00-1:00
        /// </summary>
        [XmlElement("DataDiskPolicyTimePeriod")]
        public long DataDiskPolicyTimePeriod { get; set; }

        /// <summary>
        /// 系统盘自动快照策略开关：  True：系统盘执行自动快照策略  False：系统盘不执行自动快照策略
        /// </summary>
        [XmlElement("SystemDiskPolicyEnabled")]
        public string SystemDiskPolicyEnabled { get; set; }

        /// <summary>
        /// 系统盘自动快照策略的保留天数：  1|2|3
        /// </summary>
        [XmlElement("SystemDiskPolicyRetentionDays")]
        public long SystemDiskPolicyRetentionDays { get; set; }

        /// <summary>
        /// 系统盘自动快照策略的保留上周日选项：  True：保留上周日的快照，  False：不保留
        /// </summary>
        [XmlElement("SystemDiskPolicyRetentionLastWeek")]
        public string SystemDiskPolicyRetentionLastWeek { get; set; }

        /// <summary>
        /// 系统盘自动快照策略的时间段：  4个时间段，  1：1:00-7:00  2：7:00-13:00  3：13:00-19:00  4：19:00-1:00
        /// </summary>
        [XmlElement("SystemDiskPolicyTimePeriod")]
        public long SystemDiskPolicyTimePeriod { get; set; }
    }
}
