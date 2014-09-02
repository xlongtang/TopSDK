using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TripFlightInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TripFlightInfo : TopObject
    {
        /// <summary>
        /// 航班航空公司二字码
        /// </summary>
        [XmlElement("airline_code")]
        public string AirlineCode { get; set; }

        /// <summary>
        /// 航班到达机场三字码
        /// </summary>
        [XmlElement("arr_airport_code")]
        public string ArrAirportCode { get; set; }

        /// <summary>
        /// 航班到达城市三字码
        /// </summary>
        [XmlElement("arr_city_code")]
        public string ArrCityCode { get; set; }

        /// <summary>
        /// 航班到达时间，格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("arr_time")]
        public string ArrTime { get; set; }

        /// <summary>
        /// 航班实际承运航班号
        /// </summary>
        [XmlElement("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// 航班出发机场三字码
        /// </summary>
        [XmlElement("dep_airport_code")]
        public string DepAirportCode { get; set; }

        /// <summary>
        /// 航班出发城市三字码
        /// </summary>
        [XmlElement("dep_city_code")]
        public string DepCityCode { get; set; }

        /// <summary>
        /// 航班起飞时间，格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("dep_time")]
        public string DepTime { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("extra")]
        public string Extra { get; set; }

        /// <summary>
        /// 淘宝机票平台航班id
        /// </summary>
        [XmlElement("flight_id")]
        public long FlightId { get; set; }

        /// <summary>
        /// 航班号
        /// </summary>
        [XmlElement("flight_no")]
        public string FlightNo { get; set; }

        /// <summary>
        /// 航班机型
        /// </summary>
        [XmlElement("flight_type")]
        public string FlightType { get; set; }

        /// <summary>
        /// 乘机人信息列表
        /// </summary>
        [XmlArray("passengers")]
        [XmlArrayItem("trip_flight_passenger")]
        public List<TripFlightPassenger> Passengers { get; set; }

        /// <summary>
        /// 去程或回程第几段航班，0，第1段；1，第2段航班
        /// </summary>
        [XmlElement("segment_number")]
        public long SegmentNumber { get; set; }

        /// <summary>
        /// 航段类型：0，去程；1，回程
        /// </summary>
        [XmlElement("segment_type")]
        public long SegmentType { get; set; }

        /// <summary>
        /// 特殊说明
        /// </summary>
        [XmlElement("special_rule")]
        public string SpecialRule { get; set; }

        /// <summary>
        /// 当前航段票面价格，单位：分
        /// </summary>
        [XmlElement("ticket_price")]
        public long TicketPrice { get; set; }
    }
}
