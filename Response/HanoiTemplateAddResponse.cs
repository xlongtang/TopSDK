using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiTemplateAddResponse.
    /// </summary>
    public class HanoiTemplateAddResponse : TopResponse
    {
        /// <summary>
        /// 所添加的模板id
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
