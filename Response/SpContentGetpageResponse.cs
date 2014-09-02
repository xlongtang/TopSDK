using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SpContentGetpageResponse.
    /// </summary>
    public class SpContentGetpageResponse : TopResponse
    {
        /// <summary>
        /// JSON格式的
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
