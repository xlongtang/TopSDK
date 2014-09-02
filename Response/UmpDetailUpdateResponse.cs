using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpDetailUpdateResponse.
    /// </summary>
    public class UmpDetailUpdateResponse : TopResponse
    {
        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
