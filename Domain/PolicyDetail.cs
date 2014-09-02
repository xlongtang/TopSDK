using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// PolicyDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PolicyDetail : TopObject
    {
        /// <summary>
        /// 改签规则
        /// </summary>
        [XmlElement("change_rule")]
        public string ChangeRule { get; set; }

        /// <summary>
        /// 当前政策仅支持一周的中的某些天，如1-7分别表示周一到周日
        /// </summary>
        [XmlElement("day_of_weeks")]
        public string DayOfWeeks { get; set; }

        /// <summary>
        /// ei项
        /// </summary>
        [XmlElement("ei")]
        public string Ei { get; set; }

        /// <summary>
        /// 当前政策排除的日期，录入日期将不在搜索结果页展现
        /// </summary>
        [XmlElement("exclude_date")]
        public string ExcludeDate { get; set; }

        /// <summary>
        /// 设置当前政策的备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// officeId，长度限制6位(根据航信政策可能调整)
        /// </summary>
        [XmlElement("office_id")]
        public string OfficeId { get; set; }

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
        /// 特殊说明
        /// </summary>
        [XmlElement("special_rule")]
        public string SpecialRule { get; set; }
    }
}
