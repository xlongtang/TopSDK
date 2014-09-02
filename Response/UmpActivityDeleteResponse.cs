using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpActivityDeleteResponse.
    /// </summary>
    public class UmpActivityDeleteResponse : TopResponse
    {
        /// <summary>
        /// 调用是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
