using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpDetailDeleteResponse.
    /// </summary>
    public class UmpDetailDeleteResponse : TopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
