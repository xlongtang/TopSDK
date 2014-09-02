using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WeitaoMenuDeleteResponse.
    /// </summary>
    public class WeitaoMenuDeleteResponse : TopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
