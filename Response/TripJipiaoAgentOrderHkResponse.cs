using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TripJipiaoAgentOrderHkResponse.
    /// </summary>
    public class TripJipiaoAgentOrderHkResponse : TopResponse
    {
        /// <summary>
        /// 手工HK成功失败
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
