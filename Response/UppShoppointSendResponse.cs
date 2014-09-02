using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// UppShoppointSendResponse.
    /// </summary>
    public class UppShoppointSendResponse : TopResponse
    {
        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
