using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiProxyValueGetResponse.
    /// </summary>
    public class HanoiProxyValueGetResponse : TopResponse
    {
        /// <summary>
        /// 结构化数据
        /// </summary>
        [XmlElement("model")]
        public string Model { get; set; }
    }
}
