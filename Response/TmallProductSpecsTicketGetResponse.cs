using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallProductSpecsTicketGetResponse.
    /// </summary>
    public class TmallProductSpecsTicketGetResponse : TopResponse
    {
        /// <summary>
        /// 产品规格审核单信息
        /// </summary>
        [XmlArray("tickets")]
        [XmlArrayItem("ticket")]
        public List<Ticket> Tickets { get; set; }
    }
}
