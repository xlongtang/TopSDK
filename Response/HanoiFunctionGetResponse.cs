using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiFunctionGetResponse.
    /// </summary>
    public class HanoiFunctionGetResponse : TopResponse
    {
        /// <summary>
        /// 规则数据
        /// </summary>
        [XmlElement("function")]
        public Function Function { get; set; }
    }
}
