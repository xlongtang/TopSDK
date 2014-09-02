using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaXiamiApiContractGiftSendResponse.
    /// </summary>
    public class AlibabaXiamiApiContractGiftSendResponse : TopResponse
    {
        /// <summary>
        /// 礼包订单ID
        /// </summary>
        [XmlElement("data")]
        public string Data { get; set; }
    }
}
