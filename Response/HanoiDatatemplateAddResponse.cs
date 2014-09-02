using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiDatatemplateAddResponse.
    /// </summary>
    public class HanoiDatatemplateAddResponse : TopResponse
    {
        /// <summary>
        /// 返回数据模板的唯一标识
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
