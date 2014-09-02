using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TradeWaimaiConfirmResponse.
    /// </summary>
    public class TradeWaimaiConfirmResponse : TopResponse
    {
        /// <summary>
        /// 0:失败 1:成功
        /// </summary>
        [XmlElement("ret_code")]
        public string RetCode { get; set; }
    }
}
