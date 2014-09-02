using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiDatatemplateDetailDeleteResponse.
    /// </summary>
    public class HanoiDatatemplateDetailDeleteResponse : TopResponse
    {
        /// <summary>
        /// 返回删除的条数
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
