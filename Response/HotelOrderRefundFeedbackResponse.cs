using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// HotelOrderRefundFeedbackResponse.
    /// </summary>
    public class HotelOrderRefundFeedbackResponse : TopResponse
    {
        /// <summary>
        /// 接口调用是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
