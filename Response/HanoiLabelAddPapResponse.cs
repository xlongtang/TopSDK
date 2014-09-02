using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiLabelAddPapResponse.
    /// </summary>
    public class HanoiLabelAddPapResponse : TopResponse
    {
        /// <summary>
        /// 创建标签成功后，返回的Id
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
