using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbOrderscheduleruleQueryResponse.
    /// </summary>
    public class WlbOrderscheduleruleQueryResponse : TopResponse
    {
        /// <summary>
        /// 订单调度规则列表
        /// </summary>
        [XmlArray("order_schedule_rule_list")]
        [XmlArrayItem("wlb_order_schedule_rule")]
        public List<WlbOrderScheduleRule> OrderScheduleRuleList { get; set; }

        /// <summary>
        /// 结果总数
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
