using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallEaiOrderRefundGoodReturnMgetResponse.
    /// </summary>
    public class TmallEaiOrderRefundGoodReturnMgetResponse : TopResponse
    {
        /// <summary>
        /// 是否用下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 退货单列表
        /// </summary>
        [XmlArray("return_bill_list")]
        [XmlArrayItem("return_bill")]
        public List<ReturnBill> ReturnBillList { get; set; }

        /// <summary>
        /// 查询总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
