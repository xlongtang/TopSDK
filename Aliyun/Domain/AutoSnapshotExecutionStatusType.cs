using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// AutoSnapshotExecutionStatusType Data Structure.
    /// </summary>
    [Serializable]
    public class AutoSnapshotExecutionStatusType : TopObject
    {
        /// <summary>
        /// 返回最近一次执行的状态：Standby|Excuted|Failed  Standby：刚设置完成还未开始执行或者系统盘和数据盘的策略都关闭  Executed：执行成功  Failed：执行失败
        /// </summary>
        [XmlElement("DataDiskExcutionStatus")]
        public string DataDiskExcutionStatus { get; set; }

        /// <summary>
        /// 返回最近一次执行的状态：Standby|Executed|Failed  Standby：刚设置完成还未开始执行或者系统盘和数据盘的策略都关闭  Executed：执行成功  Failed：执行失败
        /// </summary>
        [XmlElement("SystemDiskExcutionStatus")]
        public string SystemDiskExcutionStatus { get; set; }
    }
}
