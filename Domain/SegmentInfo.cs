using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// SegmentInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SegmentInfo : TopObject
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
        /// 出票状态: 0，初始状态；1，hk成功；2，hk失败；3，出票（RR）成功；4，出票（RR）失败；5，取消hk成功 6:取消hk失败
        /// </summary>
        [XmlElement("book_status")]
        public long BookStatus { get; set; }

        /// <summary>
        /// 舱位等级：0，头等舱(F)；1，商务舱(C)；2，经济舱(Y)
        /// </summary>
        [XmlElement("cabin_class")]
        public long CabinClass { get; set; }

        /// <summary>
        /// 航班舱位代码
        /// </summary>
        [XmlElement("cabin_code")]
        public string CabinCode { get; set; }

        /// <summary>
        /// 航班舱位id，淘宝系统唯一键
        /// </summary>
        [XmlElement("cabin_id")]
        public long CabinId { get; set; }

        /// <summary>
        /// 航班实际承运航班号
        /// </summary>
        [XmlElement("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// 航班儿童机建费用，单位：分
        /// </summary>
        [XmlElement("child_fee")]
        public long ChildFee { get; set; }

        /// <summary>
        /// 儿童保险分润金额，单位元
        /// </summary>
        [XmlElement("child_insure_promotion_price")]
        public long ChildInsurePromotionPrice { get; set; }

        /// <summary>
        /// 儿童销售价格，单位：分
        /// </summary>
        [XmlElement("child_price")]
        public long ChildPrice { get; set; }

        /// <summary>
        /// 航班儿童燃油税，单位：分
        /// </summary>
        [XmlElement("child_tax")]
        public long ChildTax { get; set; }

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
        /// 航班成人机建费，单位：分
        /// </summary>
        [XmlElement("fee")]
        public long Fee { get; set; }

        /// <summary>
        /// 淘宝系统航班id唯一键
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
        /// 成人保险分润金额，单位元
        /// </summary>
        [XmlElement("insure_promotion_price")]
        public long InsurePromotionPrice { get; set; }

        /// <summary>
        /// 备注信息，政策中的备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 乘机人信息列表
        /// </summary>
        [XmlArray("passengers")]
        [XmlArrayItem("passerger")]
        public List<Passerger> Passengers { get; set; }

        /// <summary>
        /// 政策id，淘宝系统政策唯一键
        /// </summary>
        [XmlElement("policy_id")]
        public long PolicyId { get; set; }

        /// <summary>
        /// 机票政策类型：6，特价；8，让利；10，特殊
        /// </summary>
        [XmlElement("policy_type")]
        public long PolicyType { get; set; }

        /// <summary>
        /// 销售价格，单位：分
        /// </summary>
        [XmlElement("price")]
        public long Price { get; set; }

        /// <summary>
        /// 航段类型：1，去程；2，回程
        /// </summary>
        [XmlElement("segment_type")]
        public long SegmentType { get; set; }

        /// <summary>
        /// 特殊说明
        /// </summary>
        [XmlElement("special_rule")]
        public string SpecialRule { get; set; }

        /// <summary>
        /// 航班成人燃油税，单位：分
        /// </summary>
        [XmlElement("tax")]
        public long Tax { get; set; }

        /// <summary>
        /// 当前航段票面价格，单位：分
        /// </summary>
        [XmlElement("ticket_price")]
        public long TicketPrice { get; set; }
    }
}
