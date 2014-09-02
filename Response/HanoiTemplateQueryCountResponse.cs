using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiTemplateQueryCountResponse.
    /// </summary>
    public class HanoiTemplateQueryCountResponse : TopResponse
    {
        /// <summary>
        /// 模板个数
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
