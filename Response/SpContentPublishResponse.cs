using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SpContentPublishResponse.
    /// </summary>
    public class SpContentPublishResponse : TopResponse
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
