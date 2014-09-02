using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// JushitaJdpUserAddResponse.
    /// </summary>
    public class JushitaJdpUserAddResponse : TopResponse
    {
        /// <summary>
        /// 是否添加成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
