using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TradeStat Data Structure.
    /// </summary>
    [Serializable]
    public class TradeStat : TopObject
    {
        /// <summary>
        /// 数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 状态名称
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
