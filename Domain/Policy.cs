using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Policy Data Structure.
    /// </summary>
    [Serializable]
    public class Policy : TopObject
    {
        /// <summary>
        /// 当前政策的代理商id，必需参数
        /// </summary>
        [XmlElement("agent_id")]
        public long AgentId { get; set; }

        /// <summary>
        /// 当前政策支持的航空公司二字码，必需参数
        /// </summary>
        [XmlElement("airline")]
        public string Airline { get; set; }

        /// <summary>
        /// 当前政策支持的到达机场三字码列表，逗号分隔字符串，必需参数
        /// </summary>
        [XmlElement("arr_airports")]
        public string ArrAirports { get; set; }

        /// <summary>
        /// 扩展字段： "rfc" 对应值 1:不退不改不签,2:收费退改签（退、改、签中任意一个收费即为收费退改签）3:免费退改签 "ipt" 对应值 1:等额行程单 2:不提供发票5:等额“行程单+发票”（对应旧的2） 6:等额发票（对应旧的1）,例如：rfc=1;ipt=1 "fdtod"对应值起飞时间“0000”为0时0分 "ldtod"对应值：到达时间“2359”为23时59分
        /// </summary>
        [XmlElement("attributes")]
        public string Attributes { get; set; }

        /// <summary>
        /// 当前政策是否自动HK，默认为非自动HK
        /// </summary>
        [XmlElement("auto_hk_flag")]
        public bool AutoHkFlag { get; set; }

        /// <summary>
        /// 当前政策的是否自动出票，默认为非自动出票
        /// </summary>
        [XmlElement("auto_ticket_flag")]
        public bool AutoTicketFlag { get; set; }

        /// <summary>
        /// @1: [{"matcher":{"mode":"ALL","list":["D"]},"priceStrategy":{"mode":  "TICKET_PRICE","modeBaseValue":500,"retention":500,"rebase":-5}}]  @2: [{"matcher"  :{"mode":"ALL","list":["D"]},"priceStrategy":{"mode":"DISCOUNT"  ,"modeBaseValue"  :null,"retention":300,"rebase":-5}}]  @3: [{"matcher":{"mode":"ALL","list":["D"]},"priceStrategy":{"mode":"Y_DISCOUNT","modeBaseValue":75,"retention":500,"rebase":-5}}]
        /// </summary>
        [XmlElement("cabin_rules")]
        public string CabinRules { get; set; }

        /// <summary>
        /// 当前政策支持的出发机场三字码列表，逗号分隔字符串，必需参数
        /// </summary>
        [XmlElement("dep_airports")]
        public string DepAirports { get; set; }

        /// <summary>
        /// 当前政策销售日期最少提前天数
        /// </summary>
        [XmlElement("first_sale_advance_day")]
        public long FirstSaleAdvanceDay { get; set; }

        /// <summary>
        /// 扩展标记，按位属性标记 , 从右到左数，第1个位表示：不PAT自动HK 第2个位表示：儿童可与成人同价 比如：“儿童可与成人同价”=true ,“不PAT自动HK”=false,则表示成二进制字符串"10",换算成十进制flags=2
        /// </summary>
        [XmlElement("flags")]
        public long Flags { get; set; }

        /// <summary>
        /// 设置包含/排除的航班号，注意格式： +CA1234,CZ3169表示包含列表， -CA1234,CZ3169表示排除列表默认是全部
        /// </summary>
        [XmlElement("flight_info")]
        public string FlightInfo { get; set; }

        /// <summary>
        /// 政策淘宝机票的主键id
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 当前政策销售日期最晚 提前天数
        /// </summary>
        [XmlElement("last_sale_advance_day")]
        public long LastSaleAdvanceDay { get; set; }

        /// <summary>
        /// 当前政策的外部产品id，用于关联代理商自身维护的政策id，必需参数，使用接口调用时唯一标识政策
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// 当前政策的详细信息，必需
        /// </summary>
        [XmlElement("policy_detail")]
        public PolicyDetail PolicyDetail { get; set; }

        /// <summary>
        /// 当前政策的政策类型：6，特价政策；8，让利政策；10，特殊政策，必需参数
        /// </summary>
        [XmlElement("policy_type")]
        public long PolicyType { get; set; }

        /// <summary>
        /// 当前政策销售有效日期的截止日期(注意，格式如：20120-03-10 10:30:31 等价2012-03-11)必需参数
        /// </summary>
        [XmlElement("sale_end_date")]
        public string SaleEndDate { get; set; }

        /// <summary>
        /// 当前政策销售有效日期的开始日期(注意，格式如：20120-03-10 10:30:31 等价2012-03-11)必需参数
        /// </summary>
        [XmlElement("sale_start_date")]
        public string SaleStartDate { get; set; }

        /// <summary>
        /// 当前特殊政策的库存信息，特殊政策时必需，待补充
        /// </summary>
        [XmlElement("seat_info")]
        public string SeatInfo { get; set; }

        /// <summary>
        /// 当前政策是否支持共享航班，默认为不支持共享航班(不支持共享航班时，如果当前航班为非承运航班，则搜索结果也不展现)
        /// </summary>
        [XmlElement("share_support")]
        public bool ShareSupport { get; set; }

        /// <summary>
        /// 当前政策的状态: 0，关闭；1，发布；2，删除；3，无效(淘宝机票自动程序处理的中间状态)  必需参数，注意如果当前为发布状态，发布后即刻可以从前台搜索到，从而可能即刻产生用订单
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 当前政策旅行有效日期的结束日期(注意，格式如：20120-03-10 10:30:31 等价2012-03-11)必需参数
        /// </summary>
        [XmlElement("travel_end_date")]
        public string TravelEndDate { get; set; }

        /// <summary>
        /// 当前政策旅行有效日期的开始日期(注意，格式，如：2012-03-10 10:30:31 等价2012-03-10)必需参数
        /// </summary>
        [XmlElement("travel_start_date")]
        public string TravelStartDate { get; set; }

        /// <summary>
        /// 行程类型: 0，单程政策；1，往返政策，必需参数
        /// </summary>
        [XmlElement("trip_type")]
        public long TripType { get; set; }
    }
}
