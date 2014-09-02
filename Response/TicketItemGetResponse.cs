using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TicketItemGetResponse.
    /// </summary>
    public class TicketItemGetResponse : TopResponse
    {
        /// <summary>
        /// 参见TicketItem数据结构文档
        /// </summary>
        [XmlElement("ticket_item")]
        public TicketItem TicketItem { get; set; }
    }
}
