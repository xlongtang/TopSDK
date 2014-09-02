using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallEaiOrderRefundMessageGetResponse.
    /// </summary>
    public class TmallEaiOrderRefundMessageGetResponse : TopResponse
    {
        /// <summary>
        /// 留言列表
        /// </summary>
        [XmlArray("message_list")]
        [XmlArrayItem("tmall_refund_message")]
        public List<TmallRefundMessage> MessageList { get; set; }

        /// <summary>
        /// 查询总数，用于分页
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
