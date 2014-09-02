using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SpContentItemPublishResponse.
    /// </summary>
    public class SpContentItemPublishResponse : TopResponse
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
