using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaAccountBalanceGetResponse.
    /// </summary>
    public class SimbaAccountBalanceGetResponse : TopResponse
    {
        /// <summary>
        /// 实时余额，”元”为单位
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }
    }
}
