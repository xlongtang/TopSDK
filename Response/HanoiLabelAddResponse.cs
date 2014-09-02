using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiLabelAddResponse.
    /// </summary>
    public class HanoiLabelAddResponse : TopResponse
    {
        /// <summary>
        /// 创建标签成功后，返回的Id
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
