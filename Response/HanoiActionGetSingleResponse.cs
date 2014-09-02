using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiActionGetSingleResponse.
    /// </summary>
    public class HanoiActionGetSingleResponse : TopResponse
    {
        /// <summary>
        /// ActionDO的json格式。
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }
    }
}
