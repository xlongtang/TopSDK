using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TripJipiaoAgentOrderSpecialConfirmResponse.
    /// </summary>
    public class TripJipiaoAgentOrderSpecialConfirmResponse : TopResponse
    {
        /// <summary>
        /// 确认能否支付成功失败
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
