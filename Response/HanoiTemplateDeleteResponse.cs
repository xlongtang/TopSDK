using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiTemplateDeleteResponse.
    /// </summary>
    public class HanoiTemplateDeleteResponse : TopResponse
    {
        /// <summary>
        /// 删除操作的返回结果
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
