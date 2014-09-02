using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallEaiOrderRefundBillsumGetResponse.
    /// </summary>
    public class TmallEaiOrderRefundBillsumGetResponse : TopResponse
    {
        /// <summary>
        /// 总数
        /// </summary>
        [XmlElement("bill_sum")]
        public long BillSum { get; set; }
    }
}
