using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// JaeClientInteractionListeningshakeResponse.
    /// </summary>
    public class JaeClientInteractionListeningshakeResponse : TopResponse
    {
        /// <summary>
        /// 无返回结果
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
