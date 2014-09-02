using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiGroupUpdateResponse.
    /// </summary>
    public class HanoiGroupUpdateResponse : TopResponse
    {
        /// <summary>
        /// 更新操作的结果
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
