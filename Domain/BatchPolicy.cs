using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// BatchPolicy Data Structure.
    /// </summary>
    [Serializable]
    public class BatchPolicy : TopObject
    {
        /// <summary>
        /// 政策所支持的航空公司二字码.必需参数
        /// </summary>
        [XmlElement("airline")]
        public string Airline { get; set; }

        /// <summary>
        /// 政策支持的到达机场列表，逗号分隔的机场三字码， 注： 1.让利(8)政策，当到达支持多个(最多25)时，出发只能支持一个； 2.特价(6)/特殊(10)政策，出发/到达城市只支持一个.必需参数
        /// </summary>
        [XmlElement("arr_airports")]
        public string ArrAirports { get; set; }

        /// <summary>
        /// 扩展字段,json格式：   "rfc" 对应值: 1.不退不改不签,2.收费退改签（退、改、签中任意一个收费即为收费退改签）,3.免费退改签 ；  "ipt" 对应值 :1:等额行程单 2:不提供发票5:等额“行程单+发票”（对应旧的2） 6:等额发票（对应旧的1）;  "fdtod"对应值：起飞时间“0000”为0时0分  "ldtod"对应值：到达时间“2359”为23时59分
        /// </summary>
        [XmlElement("attributes")]
        public string Attributes { get; set; }

        /// <summary>
        /// 政策是否支持自动HK，默认为不支持
        /// </summary>
        [XmlElement("auto_hk_flag")]
        public bool AutoHkFlag { get; set; }

        /// <summary>
        /// 政策是否支持自动出票，默认不支持， 注：自动出票时，必须同时自动HK
        /// </summary>
        [XmlElement("auto_ticket_flag")]
        public bool AutoTicketFlag { get; set; }

        /// <summary>
        /// @1: [{"matcher":{"mode":"ALL","list":["D"]},"priceStrategy":{"mode": "TICKET_PRICE","modeBaseValue":500,"retention":500,"rebase":-5}}] @2: [{"matcher" :{"mode":"ALL","list":["D"]},"priceStrategy":{"mode":"DISCOUNT" ,"modeBaseValue" :null,"retention":300,"rebase":-5}}] @3: [{"matcher":{"mode":"ALL","list":["D"]},"priceStrategy":{"mode":"Y_DISCOUNT","modeBaseValue":75,"retention":500,"rebase":-5}}] 规则说明： cabin_rules分二个字段：matcher:适应舱位（又包含两个字段：mode：匹配模式枚举(填INCLUDE），list：适应舱位列表），priceStrategy:价格策略（mode:价格模式（让利产品：DISCOUNT，特价特殊产品有四种模式：票面价用TICKET_PRICE，Y舱折扣用Y_DISCOUNT，C舱折扣用C_DISCOUNT，F舱折扣用F_DISCOUNT）；modeBaseValue:当价格模式mode为DISCOUNT，modeBaseValue不填；当价格模式mode为TICKET_PRICE，modeBaseValue填票面价；当价格模式mode为Y_DISCOUNT/C_DISCOUNT/F_DISCOUNT，modeBaseValue填对应的折扣；retention为返点的百分比；rebase为留钱） 注意：特殊政策不需要舱位时需要传入22；retention、rebase传入小数时，会取整数部分
        /// </summary>
        [XmlElement("cabin_rules")]
        public string CabinRules { get; set; }

        /// <summary>
        /// 改签规则
        /// </summary>
        [XmlElement("change_rule")]
        public string ChangeRule { get; set; }

        /// <summary>
        /// 政策适用的星期几，1-7分别表示周一到周日 注：特殊政策不能填写该字段；其它政策填写时， 包含全部时需要设置为1234567
        /// </summary>
        [XmlElement("day_of_weeks")]
        public string DayOfWeeks { get; set; }

        /// <summary>
        /// 政策支持的出发机场列表，逗号分隔的机场三字码， 注： 1.让利(8)政策，当出发支持多个(最多25)时，到达只能支持一个； 2.特价(6)/特殊(10)政策，出发/到达城市只支持一个.必需参数
        /// </summary>
        [XmlElement("dep_airports")]
        public string DepAirports { get; set; }

        /// <summary>
        /// ei项，自动HK，自动出票设定时必需
        /// </summary>
        [XmlElement("ei")]
        public string Ei { get; set; }

        /// <summary>
        /// 政策旅行有效日期中排除指定日期，设定日期将不在搜索结果页面展现 注：最多排除20天，特殊政策无此设置
        /// </summary>
        [XmlElement("exclude_date")]
        public string ExcludeDate { get; set; }

        /// <summary>
        /// 政策销售日期最早提前天数，-1表示无效
        /// </summary>
        [XmlElement("first_sale_advance_day")]
        public long FirstSaleAdvanceDay { get; set; }

        /// <summary>
        /// 扩展标记，按位属性标记 , 从右到左数，第1个位表示：不PAT自动HK 第2个位表示：儿童可与成人同价 比如：“儿童可与成人同价”=true ,“不PAT自动HK”=false,则表示成二进制字符串"10",换算成十进制flags=2
        /// </summary>
        [XmlElement("flags")]
        public long Flags { get; set; }

        /// <summary>
        /// 包含/排除的航班号，注意格式： +CA1234,CZ3166，表示包含列表 -CA1234,CZ3166，表示排除列表 默认包含所有航班； 不支持同时包含和排除
        /// </summary>
        [XmlElement("flight_info")]
        public string FlightInfo { get; set; }

        /// <summary>
        /// 当前政策销售日期最晚 提前天数,-1表示无效
        /// </summary>
        [XmlElement("last_sale_advance_day")]
        public long LastSaleAdvanceDay { get; set; }

        /// <summary>
        /// 代理商对政策的备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 政策设置为支持自动HK，自动出票时必需
        /// </summary>
        [XmlElement("office_id")]
        public string OfficeId { get; set; }

        /// <summary>
        /// 当前政策的外部产品id，用于关联代理商自身维护的政策id，必需参数，使用接口调用时唯一标识政策
        /// </summary>
        [XmlElement("out_product_id")]
        public string OutProductId { get; set; }

        /// <summary>
        /// 当前政策的政策类型：6，特价政策；8，让利政策；10，特殊政策，必需参数
        /// </summary>
        [XmlElement("policy_type")]
        public long PolicyType { get; set; }

        /// <summary>
        /// 退票规则
        /// </summary>
        [XmlElement("refund_rule")]
        public string RefundRule { get; set; }

        /// <summary>
        /// 签转规则
        /// </summary>
        [XmlElement("reissue_rule")]
        public string ReissueRule { get; set; }

        /// <summary>
        /// 政策销售日期最晚提前天数，-1表示无效
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
        /// 默认填写TOP,如需要自定义，必须大写，则按source批量删除时需要在接口中taobao.jipiao.policiesstatus.update指定参数source;通过接口taobao.jipiao.policy.process添加的政策会自动加上source为TOP,代理商后台页面录入的source为PC,excel上传的source为UPLOAD
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

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
    }
}
