using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaLaiwangPpMessageSendResponse.
    /// </summary>
    public class AlibabaLaiwangPpMessageSendResponse : TopResponse
    {
        /// <summary>
        /// issuccess
        /// </summary>
        [XmlElement("issuccess")]
        public bool Issuccess { get; set; }
    }
}
