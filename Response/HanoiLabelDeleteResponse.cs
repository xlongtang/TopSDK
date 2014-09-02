using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiLabelDeleteResponse.
    /// </summary>
    public class HanoiLabelDeleteResponse : TopResponse
    {
        /// <summary>
        /// 删除标签成功结果
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
