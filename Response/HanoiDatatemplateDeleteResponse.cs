using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HanoiDatatemplateDeleteResponse.
    /// </summary>
    public class HanoiDatatemplateDeleteResponse : TopResponse
    {
        /// <summary>
        /// 是否删除成功
        /// </summary>
        [XmlElement("value")]
        public bool Value { get; set; }
    }
}
