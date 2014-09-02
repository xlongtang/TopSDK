using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// JushitaJdpTaskUpdateResponse.
    /// </summary>
    public class JushitaJdpTaskUpdateResponse : TopResponse
    {
        /// <summary>
        /// 更新任务是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
