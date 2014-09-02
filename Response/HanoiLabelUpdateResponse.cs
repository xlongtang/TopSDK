using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiLabelUpdateResponse.
    /// </summary>
    public class HanoiLabelUpdateResponse : TopResponse
    {
        /// <summary>
        /// 更新操作的结果
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
