using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SpContentDetailGetResponse.
    /// </summary>
    public class SpContentDetailGetResponse : TopResponse
    {
        /// <summary>
        /// 内容详情
        /// </summary>
        [XmlElement("content")]
        public SpContentDOForDetail Content { get; set; }
    }
}
