using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// BillBookBillsGetResponse.
    /// </summary>
    public class BillBookBillsGetResponse : TopResponse
    {
        /// <summary>
        /// 虚拟账户账单列表
        /// </summary>
        [XmlArray("bills")]
        [XmlArrayItem("book_bill")]
        public List<BookBill> Bills { get; set; }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 当前查询的结果数,非总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
