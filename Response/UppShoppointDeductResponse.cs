using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// UppShoppointDeductResponse.
    /// </summary>
    public class UppShoppointDeductResponse : TopResponse
    {
        /// <summary>
        /// 是否调用成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
