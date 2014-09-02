using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// AtOrder Data Structure.
    /// </summary>
    [Serializable]
    public class AtOrder : TopObject
    {
        /// <summary>
        /// 订单基础信息
        /// </summary>
        [XmlElement("base_info")]
        public BaseInfo BaseInfo { get; set; }

        /// <summary>
        /// 订单行政购票信息
        /// </summary>
        [XmlElement("corp_info")]
        public CorpInfo CorpInfo { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extra")]
        public string Extra { get; set; }

        /// <summary>
        /// 订单行程单信息
        /// </summary>
        [XmlElement("itinerary")]
        public Itinerary Itinerary { get; set; }

        /// <summary>
        /// 订单航段信息
        /// </summary>
        [XmlArray("segment_infos")]
        [XmlArrayItem("segment_info")]
        public List<SegmentInfo> SegmentInfos { get; set; }
    }
}
