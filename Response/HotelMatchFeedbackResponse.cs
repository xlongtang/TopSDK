using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HotelMatchFeedbackResponse.
    /// </summary>
    public class HotelMatchFeedbackResponse : TopResponse
    {
        /// <summary>
        /// 结果回传是否成功
        /// </summary>
        [XmlElement("succ")]
        public bool Succ { get; set; }
    }
}
