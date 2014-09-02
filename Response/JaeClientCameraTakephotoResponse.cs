using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// JaeClientCameraTakephotoResponse.
    /// </summary>
    public class JaeClientCameraTakephotoResponse : TopResponse
    {
        /// <summary>
        /// 淘宝CDN上图片的url地址
        /// </summary>
        [XmlElement("urls")]
        public string Urls { get; set; }
    }
}
