using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WaitingTimeById Data Structure.
    /// </summary>
    [Serializable]
    public class WaitingTimeById : TopObject
    {
        /// <summary>
        /// 平均等待时间长度（秒）
        /// </summary>
        [XmlElement("avg_waiting_times")]
        public long AvgWaitingTimes { get; set; }

        /// <summary>
        /// 客服人员ID
        /// </summary>
        [XmlElement("service_staff_id")]
        public string ServiceStaffId { get; set; }
    }
}
