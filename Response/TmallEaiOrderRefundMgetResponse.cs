using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallEaiOrderRefundMgetResponse.
    /// </summary>
    public class TmallEaiOrderRefundMgetResponse : TopResponse
    {
        /// <summary>
        /// 是否有下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 退款单列表
        /// </summary>
        [XmlArray("refund_bill_list")]
        [XmlArrayItem("refund_bill")]
        public List<RefundBill> RefundBillList { get; set; }

        /// <summary>
        /// 查询总数，用于分页
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
