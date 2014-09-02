using System;
using System.Collections.Generic;
using Top.Api.Response;
using Top.Api.Util;

namespace Top.Api.Request
{
    /// <summary>
    /// TOP API: taobao.jipiao.policy.process
    /// </summary>
    public class JipiaoPolicyProcessRequest : ITopRequest<JipiaoPolicyProcessResponse>
    {
        /// <summary>
        /// 政策所支持的航空公司二字码
        /// </summary>
        public string Airline { get; set; }

        /// <summary>
        /// 政策支持的到达机场列表，逗号分隔的机场三字码，  注：   1.让利(8)政策，当到达支持多个(最多25)时，出发只能支持一个；   2.特价(6)/特殊(10)政策，出发/到达城市只支持一个
        /// </summary>
        public string ArrAirports { get; set; }

        /// <summary>
        /// 扩展字段：      "rfc" 对应值 1:不退不改不签,2:收费退改签（退、改、签中任意一个收费即为收费退改签）3:免费退改签      "ipt" 对应值 1:等额行程单 2:不提供发票5:等额“行程单+发票”（对应旧的2） 6:等额发票（对应旧的1）,例如：rfc=1;ipt=1      "fdtod"对应值起飞时间“0000”为0时0分       "ldtod"对应值：到达时间“2359”为23时59分
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        /// 政策是否支持自动HK，默认为不支持
        /// </summary>
        public Nullable<bool> AutoHkFlag { get; set; }

        /// <summary>
        /// 政策是否支持自动出票，默认不支持，  注：自动出票时，必须同时自动HK
        /// </summary>
        public Nullable<bool> AutoTicketFlag { get; set; }

        /// <summary>
        /// @1: [{"matcher":{"mode":"ALL","list":["D"]},"priceStrategy":{"mode": "TICKET_PRICE","modeBaseValue":500,"retention":500,"rebase":-5}}]  @2: [{"matcher" :{"mode":"ALL","list":["D"]},"priceStrategy":{"mode":"DISCOUNT" ,"modeBaseValue" :null,"retention":300,"rebase":-5}}]  @3: [{"matcher":{"mode":"ALL","list":["D"]},"priceStrategy":{"mode":"Y_DISCOUNT","modeBaseValue":75,"retention":500,"rebase":-5}}]  规则说明： cabin_rules分二个字段：matcher:适应舱位（又包含两个字段：mode：匹配模式枚举(填INCLUDE），list：适应舱位列表），priceStrategy:价格策略（mode:价格模式（让利产品：DISCOUNT，特价特殊产品有四种模式：票面价用TICKET_PRICE，Y舱折扣用Y_DISCOUNT，C舱折扣用C_DISCOUNT，F舱折扣用F_DISCOUNT）；modeBaseValue:当价格模式mode为DISCOUNT，modeBaseValue不填；当价格模式mode为TICKET_PRICE，modeBaseValue填票面价；当价格模式mode为Y_DISCOUNT/C_DISCOUNT/F_DISCOUNT，modeBaseValue填对应的折扣；retention为返点的百分比；rebase为留钱） 注意：特殊政策不需要舱位时需要传入22；retention、rebase传入小数时，会取整数部分
        /// </summary>
        public string CabinRules { get; set; }

        /// <summary>
        /// 改签规则
        /// </summary>
        public string ChangeRule { get; set; }

        /// <summary>
        /// 政策适用的星期几，1-7分别表示周一到周日  注：特殊政策不能填写该字段；其它政策填写时，  包含全部时需要设置为1234567
        /// </summary>
        public string DayOfWeeks { get; set; }

        /// <summary>
        /// 政策支持的出发机场列表，逗号分隔的机场三字码，  注：  1.让利(8)政策，当出发支持多个(最多25)时，到达只能支持一个；  2.特价(6)/特殊(10)政策，出发/到达城市只支持一个
        /// </summary>
        public string DepAirports { get; set; }

        /// <summary>
        /// ei项，自动HK，自动出票设定时必需
        /// </summary>
        public string Ei { get; set; }

        /// <summary>
        /// 政策旅行有效日期中排除指定日期，设定日期将不在搜索结果页面展现  注：最多排除20天，特殊政策无此设置
        /// </summary>
        public string ExcludeDate { get; set; }

        /// <summary>
        /// 政策销售日期最早提前天数，默认-1表示无效
        /// </summary>
        public Nullable<long> FirstSaleAdvanceDay { get; set; }

        /// <summary>
        /// flags是二进制标志  从右到左数，第1个位表示：不PAT自动HK   第2个位表示：儿童可与成人同价  比如：“儿童可与成人同价”=true ,“不PAT自动HK”=false,则表示成二进制字符串"10",换算成十进制flags=2
        /// </summary>
        public Nullable<long> Flags { get; set; }

        /// <summary>
        /// 包含/排除的航班号，注意格式：  +CA1234,CZ3166，表示包含列表  -CA1234,CZ3166，表示排除列表  默认包含所有航班；  不支持同时包含和排除
        /// </summary>
        public string FlightInfo { get; set; }

        /// <summary>
        /// 政策销售日期最晚提前天数，默认-1表示无效
        /// </summary>
        public Nullable<long> LastSaleAdvanceDay { get; set; }

        /// <summary>
        /// 代理商对政策的备注信息
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 政策设置为支持自动HK，自动出票时必需
        /// </summary>
        public string OfficeId { get; set; }

        /// <summary>
        /// 政策的外部id，用于关联代理商自身维护的政策id，提供外部产品id时，可以在查询和修改时作为唯一条件使用
        /// </summary>
        public string OutProductId { get; set; }

        /// <summary>
        /// 0，type为0时，不需要设置；  1，type为1时，表示policy_id为政策id  2，type为2时，表示policy_id为政策out_product_id
        /// </summary>
        public string PolicyId { get; set; }

        /// <summary>
        /// 政策类型：6，特价政策；8，让利政策；10，特殊政策
        /// </summary>
        public Nullable<long> PolicyType { get; set; }

        /// <summary>
        /// 退票规则
        /// </summary>
        public string RefundRule { get; set; }

        /// <summary>
        /// 签转规则
        /// </summary>
        public string ReissueRule { get; set; }

        /// <summary>
        /// 政策销售有效日期的截止日期(注意，格式如：20120-03-10 10:30:31 等价2012-03-11)
        /// </summary>
        public Nullable<DateTime> SaleEndDate { get; set; }

        /// <summary>
        /// 政策销售有效日期的开始日期(注意，格式如：20120-03-10 10:30:31 等价2012-03-11)
        /// </summary>
        public Nullable<DateTime> SaleStartDate { get; set; }

        /// <summary>
        /// 政策类型为10时，用于设置政策的每天的库存信息
        /// </summary>
        public string SeatInfo { get; set; }

        /// <summary>
        /// 政策是否支持共享航班，默认为不支持；设置不支持情况下，当航班的实际承运方不是当前航空公司，则搜索结果页不能展现
        /// </summary>
        public Nullable<bool> ShareSupport { get; set; }

        /// <summary>
        /// 特殊说明,此字段不再使用,填写内容将会报相应的填写错误
        /// </summary>
        public string SpecialRule { get; set; }

        /// <summary>
        /// 政策旅行有效日期的结束日期(注意，格式如：20120-03-10 10:30:31 等价2012-03-11)
        /// </summary>
        public Nullable<DateTime> TravelEndDate { get; set; }

        /// <summary>
        /// 政策旅行有效日期的开始日期(注意，格式，如：2012-03-10 10:30:31 等价2012-03-10)
        /// </summary>
        public Nullable<DateTime> TravelStartDate { get; set; }

        /// <summary>
        /// 0，表示添加政策；  1，表示按id修改政策；  2，表示按out_product_id修改政策
        /// </summary>
        public Nullable<long> Type { get; set; }

        private IDictionary<string, string> otherParameters;

        #region ITopRequest Members

        public string GetApiName()
        {
            return "taobao.jipiao.policy.process";
        }

        public IDictionary<string, string> GetParameters()
        {
            TopDictionary parameters = new TopDictionary();
            parameters.Add("airline", this.Airline);
            parameters.Add("arr_airports", this.ArrAirports);
            parameters.Add("attributes", this.Attributes);
            parameters.Add("auto_hk_flag", this.AutoHkFlag);
            parameters.Add("auto_ticket_flag", this.AutoTicketFlag);
            parameters.Add("cabin_rules", this.CabinRules);
            parameters.Add("change_rule", this.ChangeRule);
            parameters.Add("day_of_weeks", this.DayOfWeeks);
            parameters.Add("dep_airports", this.DepAirports);
            parameters.Add("ei", this.Ei);
            parameters.Add("exclude_date", this.ExcludeDate);
            parameters.Add("first_sale_advance_day", this.FirstSaleAdvanceDay);
            parameters.Add("flags", this.Flags);
            parameters.Add("flight_info", this.FlightInfo);
            parameters.Add("last_sale_advance_day", this.LastSaleAdvanceDay);
            parameters.Add("memo", this.Memo);
            parameters.Add("office_id", this.OfficeId);
            parameters.Add("out_product_id", this.OutProductId);
            parameters.Add("policy_id", this.PolicyId);
            parameters.Add("policy_type", this.PolicyType);
            parameters.Add("refund_rule", this.RefundRule);
            parameters.Add("reissue_rule", this.ReissueRule);
            parameters.Add("sale_end_date", this.SaleEndDate);
            parameters.Add("sale_start_date", this.SaleStartDate);
            parameters.Add("seat_info", this.SeatInfo);
            parameters.Add("share_support", this.ShareSupport);
            parameters.Add("special_rule", this.SpecialRule);
            parameters.Add("travel_end_date", this.TravelEndDate);
            parameters.Add("travel_start_date", this.TravelStartDate);
            parameters.Add("type", this.Type);
            parameters.AddAll(this.otherParameters);
            return parameters;
        }

        public void Validate()
        {
            RequestValidator.ValidateRequired("airline", this.Airline);
            RequestValidator.ValidateMaxLength("airline", this.Airline, 2);
            RequestValidator.ValidateRequired("arr_airports", this.ArrAirports);
            RequestValidator.ValidateMaxLength("arr_airports", this.ArrAirports, 100);
            RequestValidator.ValidateMaxLength("attributes", this.Attributes, 300);
            RequestValidator.ValidateRequired("cabin_rules", this.CabinRules);
            RequestValidator.ValidateMaxLength("cabin_rules", this.CabinRules, 300);
            RequestValidator.ValidateMaxLength("change_rule", this.ChangeRule, 300);
            RequestValidator.ValidateRequired("day_of_weeks", this.DayOfWeeks);
            RequestValidator.ValidateMaxLength("day_of_weeks", this.DayOfWeeks, 7);
            RequestValidator.ValidateRequired("dep_airports", this.DepAirports);
            RequestValidator.ValidateMaxLength("dep_airports", this.DepAirports, 100);
            RequestValidator.ValidateMaxLength("ei", this.Ei, 20);
            RequestValidator.ValidateMaxLength("exclude_date", this.ExcludeDate, 200);
            RequestValidator.ValidateMaxValue("flags", this.Flags, 9223372036854775807);
            RequestValidator.ValidateMinValue("flags", this.Flags, 0);
            RequestValidator.ValidateMaxLength("flight_info", this.FlightInfo, 1000);
            RequestValidator.ValidateMaxLength("memo", this.Memo, 500);
            RequestValidator.ValidateMaxLength("office_id", this.OfficeId, 32);
            RequestValidator.ValidateMaxLength("out_product_id", this.OutProductId, 64);
            RequestValidator.ValidateRequired("policy_type", this.PolicyType);
            RequestValidator.ValidateMaxLength("refund_rule", this.RefundRule, 300);
            RequestValidator.ValidateMaxLength("reissue_rule", this.ReissueRule, 300);
            RequestValidator.ValidateRequired("sale_end_date", this.SaleEndDate);
            RequestValidator.ValidateRequired("sale_start_date", this.SaleStartDate);
            RequestValidator.ValidateMaxLength("seat_info", this.SeatInfo, 1500);
            RequestValidator.ValidateMaxLength("special_rule", this.SpecialRule, 300);
            RequestValidator.ValidateRequired("travel_end_date", this.TravelEndDate);
            RequestValidator.ValidateRequired("travel_start_date", this.TravelStartDate);
            RequestValidator.ValidateRequired("type", this.Type);
            RequestValidator.ValidateMaxValue("type", this.Type, 2);
            RequestValidator.ValidateMinValue("type", this.Type, 0);
        }

        #endregion

        public void AddOtherParameter(string key, string value)
        {
            if (this.otherParameters == null)
            {
                this.otherParameters = new TopDictionary();
            }
            this.otherParameters.Add(key, value);
        }
    }
}
