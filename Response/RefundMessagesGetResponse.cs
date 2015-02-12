using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// RefundMessagesGetResponse.
    /// </summary>
    public class RefundMessagesGetResponse : TopResponse
    {
        /// <summary>
        /// 查询到的退款留言/凭证列表
        /// </summary>
        [XmlArray("refund_messages")]
        [XmlArrayItem("refund_message")]
        public List<RefundMessage> RefundMessages { get; set; }

        /// <summary>
        /// 查询到的退款留言/凭证总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
