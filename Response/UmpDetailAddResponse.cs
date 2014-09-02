using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpDetailAddResponse.
    /// </summary>
    public class UmpDetailAddResponse : TopResponse
    {
        /// <summary>
        /// 活动详情的id
        /// </summary>
        [XmlElement("detail_id")]
        public long DetailId { get; set; }
    }
}
