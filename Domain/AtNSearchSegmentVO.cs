using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// AtNSearchSegmentVO Data Structure.
    /// </summary>
    [Serializable]
    public class AtNSearchSegmentVO : TopObject
    {
        /// <summary>
        /// 活动优惠金额,单位分。
        /// </summary>
        [XmlElement("activity_bonus")]
        public string ActivityBonus { get; set; }

        /// <summary>
        /// 活动编号
        /// </summary>
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 到达城市三字码
        /// </summary>
        [XmlElement("arr_city")]
        public string ArrCity { get; set; }

        /// <summary>
        /// 是否自动出票。
        /// </summary>
        [XmlElement("auto_book")]
        public bool AutoBook { get; set; }

        /// <summary>
        /// 基准舱位（FCY）价格，单位分
        /// </summary>
        [XmlElement("basic_cabin_price")]
        public string BasicCabinPrice { get; set; }

        /// <summary>
        /// 舱位代码
        /// </summary>
        [XmlElement("cabin")]
        public string Cabin { get; set; }

        /// <summary>
        /// 舱位等级。0-头等舱；1-商务舱；2-经济舱
        /// </summary>
        [XmlElement("cabin_class")]
        public long CabinClass { get; set; }

        /// <summary>
        /// 舱位座位数，123456789AQSCL等。
        /// </summary>
        [XmlElement("cabin_num")]
        public string CabinNum { get; set; }

        /// <summary>
        /// 出发城市三字码
        /// </summary>
        [XmlElement("dep_city")]
        public string DepCity { get; set; }

        /// <summary>
        /// 运价类型。0-公布运价；1-折扣运价；2-B2B/卖家接口政策；3-航司外部产品
        /// </summary>
        [XmlElement("fare_type")]
        public long FareType { get; set; }

        /// <summary>
        /// 产品打标，2的N次方标记。
        /// </summary>
        [XmlElement("flag")]
        public long Flag { get; set; }

        /// <summary>
        /// 航班号
        /// </summary>
        [XmlElement("flight_no")]
        public string FlightNo { get; set; }

        /// <summary>
        /// 发票提供类型。1-提供（等额行程单）；2-不提供；5-提供（等额行程单+发票）；6-提供（等额发票）
        /// </summary>
        [XmlElement("invoice_type")]
        public long InvoiceType { get; set; }

        /// <summary>
        /// 销售价格，单位分。
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 航段标识。00-去程第一段；01-去程第二段；10-回程第一段；11-回程第二段。
        /// </summary>
        [XmlElement("segment_number")]
        public string SegmentNumber { get; set; }

        /// <summary>
        /// 库存类型，0-共有库存；1-私有库存；2-可申请库存
        /// </summary>
        [XmlElement("stock_type")]
        public long StockType { get; set; }

        /// <summary>
        /// 产品票面价，单位分
        /// </summary>
        [XmlElement("ticket_price")]
        public string TicketPrice { get; set; }
    }
}
