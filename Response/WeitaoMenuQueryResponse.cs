using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WeitaoMenuQueryResponse.
    /// </summary>
    public class WeitaoMenuQueryResponse : TopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 菜单数据
        /// </summary>
        [XmlElement("menu")]
        public string Menu { get; set; }
    }
}
