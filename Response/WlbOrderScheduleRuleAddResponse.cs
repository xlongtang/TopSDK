using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WlbOrderScheduleRuleAddResponse.
    /// </summary>
    public class WlbOrderScheduleRuleAddResponse : TopResponse
    {
        /// <summary>
        /// 新增成功的订单调度规则id
        /// </summary>
        [XmlElement("schedule_rule_id")]
        public long ScheduleRuleId { get; set; }
    }
}
