using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpToolGetResponse.
    /// </summary>
    public class UmpToolGetResponse : TopResponse
    {
        /// <summary>
        /// 工具信息内容，格式为json，可以通过提供给的sdk里面的MarketingBuilder来处理这个内容
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }
    }
}
