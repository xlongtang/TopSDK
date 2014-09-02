using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// StaffEvalStatOnDay Data Structure.
    /// </summary>
    [Serializable]
    public class StaffEvalStatOnDay : TopObject
    {
        /// <summary>
        /// 评价产生的日期
        /// </summary>
        [XmlElement("eval_date")]
        public string EvalDate { get; set; }

        /// <summary>
        /// 客服评价统计列表
        /// </summary>
        [XmlArray("staff_eval_stat_by_ids")]
        [XmlArrayItem("staff_eval_stat_by_id")]
        public List<StaffEvalStatById> StaffEvalStatByIds { get; set; }
    }
}
