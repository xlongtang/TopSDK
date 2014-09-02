using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiTemplateUpdateResponse.
    /// </summary>
    public class HanoiTemplateUpdateResponse : TopResponse
    {
        /// <summary>
        /// 成功修改的结果
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
