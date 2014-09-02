using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiGroupAddPapResponse.
    /// </summary>
    public class HanoiGroupAddPapResponse : TopResponse
    {
        /// <summary>
        /// 创建成功，返回分组的id
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
