using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TripJipiaoAgentOrderConfirmResponse.
    /// </summary>
    public class TripJipiaoAgentOrderConfirmResponse : TopResponse
    {
        /// <summary>
        /// 确认成功失败
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
