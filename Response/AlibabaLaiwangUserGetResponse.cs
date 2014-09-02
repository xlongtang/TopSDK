using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaLaiwangUserGetResponse.
    /// </summary>
    public class AlibabaLaiwangUserGetResponse : TopResponse
    {
        /// <summary>
        /// 来往用户信息
        /// </summary>
        [XmlElement("user")]
        public LaiwangUser User { get; set; }
    }
}
