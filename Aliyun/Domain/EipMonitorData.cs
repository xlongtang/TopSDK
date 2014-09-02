using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// EipMonitorData Data Structure.
    /// </summary>
    [Serializable]
    public class EipMonitorData : TopObject
    {
        /// <summary>
        /// EIP的带宽（单位时间内的网络流量），单位为kbytes/s。
        /// </summary>
        [XmlElement("EipBandwidth")]
        public long EipBandwidth { get; set; }

        /// <summary>
        /// 一段时间（Period）内，EIP网络流量，单位Kbytes。
        /// </summary>
        [XmlElement("EipFlow")]
        public long EipFlow { get; set; }

        /// <summary>
        /// 一段时间（Period）内，EIP接受和发送的报文总数。
        /// </summary>
        [XmlElement("EipPackets")]
        public long EipPackets { get; set; }

        /// <summary>
        /// 一段时间（Period）内，EIP接收到的数据流量，单位：kbytes。
        /// </summary>
        [XmlElement("EipRx")]
        public long EipRx { get; set; }

        /// <summary>
        /// 一段时间（Period）内，EIP接发送的数据流量，单位：kbytes。
        /// </summary>
        [XmlElement("EipTx")]
        public long EipTx { get; set; }

        /// <summary>
        /// 查询流量的时间点，格式依照ISO8601表示法
        /// </summary>
        [XmlElement("TimeStamp")]
        public string TimeStamp { get; set; }
    }
}
