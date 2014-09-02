using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiGroupDeleteResponse.
    /// </summary>
    public class HanoiGroupDeleteResponse : TopResponse
    {
        /// <summary>
        /// 删除操作返回结果
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
