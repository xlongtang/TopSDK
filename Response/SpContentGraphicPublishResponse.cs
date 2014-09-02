using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SpContentGraphicPublishResponse.
    /// </summary>
    public class SpContentGraphicPublishResponse : TopResponse
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
