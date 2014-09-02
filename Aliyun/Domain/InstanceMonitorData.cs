using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// InstanceMonitorData Data Structure.
    /// </summary>
    [Serializable]
    public class InstanceMonitorData : TopObject
    {
        /// <summary>
        /// 磁盘读带宽，单位：byte/s。
        /// </summary>
        [XmlElement("BPSRead")]
        public long BPSRead { get; set; }

        /// <summary>
        /// 磁盘写带宽，单位：byte/s。
        /// </summary>
        [XmlElement("BPSWrite")]
        public long BPSWrite { get; set; }

        /// <summary>
        /// CPU的使用比例，单位：百分比（%）。
        /// </summary>
        [XmlElement("CPU")]
        public long CPU { get; set; }

        /// <summary>
        /// IO读操作，单位：次/s。
        /// </summary>
        [XmlElement("IOPSRead")]
        public long IOPSRead { get; set; }

        /// <summary>
        /// IO写操作，单位：次/s。
        /// </summary>
        [XmlElement("IOPSWrite")]
        public long IOPSWrite { get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [XmlElement("InstanceId")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 云服务器实例的带宽（单位时间内的网络流量），单位为kbytes/s。
        /// </summary>
        [XmlElement("InternetBandwidth")]
        public long InternetBandwidth { get; set; }

        /// <summary>
        /// 云服务器实例网络流量。
        /// </summary>
        [XmlElement("InternetFlow")]
        public long InternetFlow { get; set; }

        /// <summary>
        /// 云服务器实例接收到的数据流量，单位：kbytes。
        /// </summary>
        [XmlElement("InternetRX")]
        public long InternetRX { get; set; }

        /// <summary>
        /// 云服务器实例接发送的数据流量，单位：kbytes。
        /// </summary>
        [XmlElement("InternetTX")]
        public long InternetTX { get; set; }

        /// <summary>
        /// 云服务器实例的带宽（单位时间内的网络流量），单位为kbytes/s。
        /// </summary>
        [XmlElement("IntranetBandwidth")]
        public long IntranetBandwidth { get; set; }

        /// <summary>
        /// 云服务器实例网络流量，单位：kbytes。
        /// </summary>
        [XmlElement("IntranetFlow")]
        public long IntranetFlow { get; set; }

        /// <summary>
        /// 云服务器实例接收到的数据流量，单位：kbytes。
        /// </summary>
        [XmlElement("IntranetRX")]
        public long IntranetRX { get; set; }

        /// <summary>
        /// 云服务器实例接发送的数据流量，单位：kbytes。
        /// </summary>
        [XmlElement("IntranetTX")]
        public long IntranetTX { get; set; }

        /// <summary>
        /// 内存的大小，单位：MB。
        /// </summary>
        [XmlElement("Memory")]
        public long Memory { get; set; }

        /// <summary>
        /// 查询流量的时间点，格式依照ISO8601表示法
        /// </summary>
        [XmlElement("TimeStamp")]
        public string TimeStamp { get; set; }
    }
}
