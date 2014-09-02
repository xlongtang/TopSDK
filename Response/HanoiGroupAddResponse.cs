using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiGroupAddResponse.
    /// </summary>
    public class HanoiGroupAddResponse : TopResponse
    {
        /// <summary>
        /// 创建成功，返回分组的id
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
