using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaLaiwangPpMenuCreateResponse.
    /// </summary>
    public class AlibabaLaiwangPpMenuCreateResponse : TopResponse
    {
        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("issuccess")]
        public bool Issuccess { get; set; }
    }
}
