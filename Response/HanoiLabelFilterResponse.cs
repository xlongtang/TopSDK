using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiLabelFilterResponse.
    /// </summary>
    public class HanoiLabelFilterResponse : TopResponse
    {
        /// <summary>
        /// 匹配结果
        /// </summary>
        [XmlElement("filter")]
        public bool Filter { get; set; }
    }
}
