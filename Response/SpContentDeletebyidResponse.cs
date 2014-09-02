using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// SpContentDeletebyidResponse.
    /// </summary>
    public class SpContentDeletebyidResponse : TopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
