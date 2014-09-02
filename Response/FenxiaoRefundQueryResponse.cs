using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoRefundQueryResponse.
    /// </summary>
    public class FenxiaoRefundQueryResponse : TopResponse
    {
        /// <summary>
        /// 代销采购退款列表
        /// </summary>
        [XmlArray("refund_list")]
        [XmlArrayItem("refund_detail")]
        public List<RefundDetail> RefundList { get; set; }

        /// <summary>
        /// 按查询条件查到的记录总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
