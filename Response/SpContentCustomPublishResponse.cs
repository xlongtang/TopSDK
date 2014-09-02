using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SpContentCustomPublishResponse.
    /// </summary>
    public class SpContentCustomPublishResponse : TopResponse
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
