using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// QtReportDeleteResponse.
    /// </summary>
    public class QtReportDeleteResponse : TopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
