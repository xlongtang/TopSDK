using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TripOrder Data Structure.
    /// </summary>
    [Serializable]
    public class TripOrder : TopObject
    {
        /// <summary>
        /// 订单基础信息
        /// </summary>
        [XmlElement("base_info")]
        public TripBaseInfo BaseInfo { get; set; }

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
        /// 订单航班信息（包含航班乘机人）
        /// </summary>
        [XmlArray("flight_infos")]
        [XmlArrayItem("trip_flight_info")]
        public List<TripFlightInfo> FlightInfos { get; set; }

        /// <summary>
        /// 订单行程单信息
        /// </summary>
        [XmlElement("itinerary")]
        public Itinerary Itinerary { get; set; }
    }
}
