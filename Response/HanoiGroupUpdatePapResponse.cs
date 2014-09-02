using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiGroupUpdatePapResponse.
    /// </summary>
    public class HanoiGroupUpdatePapResponse : TopResponse
    {
        /// <summary>
        /// 更新操作的结果
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
