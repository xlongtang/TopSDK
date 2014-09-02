using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiGroupLabelDeleteResponse.
    /// </summary>
    public class HanoiGroupLabelDeleteResponse : TopResponse
    {
        /// <summary>
        /// 修改成功结果
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
