using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// QtReportGetResponse.
    /// </summary>
    public class QtReportGetResponse : TopResponse
    {
        /// <summary>
        /// 质检报告对象
        /// </summary>
        [XmlElement("qt_report")]
        public QtReport QtReport { get; set; }
    }
}
