using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Ticket Data Structure.
    /// </summary>
    [Serializable]
    public class Ticket : TopObject
    {
        /// <summary>
        /// 如果产品规格，需要商家审核，为商家审核用户ID
        /// </summary>
        [XmlElement("audit_seller_id")]
        public long AuditSellerId { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        [XmlElement("create_user_id")]
        public long CreateUserId { get; set; }

        /// <summary>
        /// 产品规格申请时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 产品规格审核单最后修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 关于审核原因，更详细的说明
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 审核原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 产品规格ID
        /// </summary>
        [XmlElement("spec_id")]
        public long SpecId { get; set; }

        /// <summary>
        /// 1, "商家确认"  2, "商家拒绝"  3, "小二确认"  4, "小二拒绝"  5, "待商家处理"  6, "商家审核超时"  7, "待小二审核"
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }
    }
}
