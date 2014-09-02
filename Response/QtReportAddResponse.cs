using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// QtReportAddResponse.
    /// </summary>
    public class QtReportAddResponse : TopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
