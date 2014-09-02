using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// AlipayEbppBillKeySearchResponse.
    /// </summary>
    public class AlipayEbppBillKeySearchResponse : TopResponse
    {
        /// <summary>
        /// 请求受理ID。
        /// </summary>
        [XmlElement("task_id")]
        public string TaskId { get; set; }
    }
}
