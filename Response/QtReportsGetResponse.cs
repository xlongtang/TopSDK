using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// QtReportsGetResponse.
    /// </summary>
    public class QtReportsGetResponse : TopResponse
    {
        /// <summary>
        /// 质检报告列表
        /// </summary>
        [XmlArray("reports")]
        [XmlArrayItem("qt_report")]
        public List<QtReport> Reports { get; set; }
    }
}
