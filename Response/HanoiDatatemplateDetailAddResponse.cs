using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiDatatemplateDetailAddResponse.
    /// </summary>
    public class HanoiDatatemplateDetailAddResponse : TopResponse
    {
        /// <summary>
        /// 返回增加的详情个数
        /// </summary>
        [XmlElement("value")]
        public long Value { get; set; }
    }
}
