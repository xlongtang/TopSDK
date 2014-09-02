using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// QtReportUpdateResponse.
    /// </summary>
    public class QtReportUpdateResponse : TopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
