using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WeitaoMenuCreateResponse.
    /// </summary>
    public class WeitaoMenuCreateResponse : TopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 菜单
        /// </summary>
        [XmlElement("menu")]
        public string Menu { get; set; }
    }
}
