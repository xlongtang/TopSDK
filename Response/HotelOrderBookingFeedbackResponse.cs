using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HotelOrderBookingFeedbackResponse.
    /// </summary>
    public class HotelOrderBookingFeedbackResponse : TopResponse
    {
        /// <summary>
        /// 接口调用是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
