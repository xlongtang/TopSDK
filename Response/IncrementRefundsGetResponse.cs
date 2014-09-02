using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// IncrementRefundsGetResponse.
    /// </summary>
    public class IncrementRefundsGetResponse : TopResponse
    {
        /// <summary>
        /// 获取的退款通知消息体 ，具体字段见NotifyRefund数据结构
        /// </summary>
        [XmlArray("notify_refunds")]
        [XmlArrayItem("notify_refund")]
        public List<NotifyRefund> NotifyRefunds { get; set; }

        /// <summary>
        /// 搜索到符合条件的结果总数。
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
