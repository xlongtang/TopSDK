using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// BillBillsGetResponse.
    /// </summary>
    public class BillBillsGetResponse : TopResponse
    {
        /// <summary>
        /// 账单列表
        /// </summary>
        [XmlArray("bills")]
        [XmlArrayItem("bill")]
        public List<Bill> Bills { get; set; }

        /// <summary>
        /// 是否存在下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 当前页查询返回的结果数(0-100)。相同的查询时间段条件下，最大只能获取总共5000条记录。所以当大于等于5000时 ISV可以通过start_time及end_time来进行拆分，以保证可以查询到全部数据
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
