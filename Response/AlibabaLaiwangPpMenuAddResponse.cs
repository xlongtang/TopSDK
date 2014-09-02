using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaLaiwangPpMenuAddResponse.
    /// </summary>
    public class AlibabaLaiwangPpMenuAddResponse : TopResponse
    {
        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("issuccess")]
        public bool Issuccess { get; set; }
    }
}
