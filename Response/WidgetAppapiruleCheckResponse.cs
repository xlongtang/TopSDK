using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WidgetAppapiruleCheckResponse.
    /// </summary>
    public class WidgetAppapiruleCheckResponse : TopResponse
    {
        /// <summary>
        /// 当前app是否可以调用此api。可以返回true，不可用返回false。
        /// </summary>
        [XmlElement("call_permission")]
        public string CallPermission { get; set; }

        /// <summary>
        /// 此api请求的http类型：get或post
        /// </summary>
        [XmlElement("http_method")]
        public string HttpMethod { get; set; }

        /// <summary>
        /// 此api是否需要用户授权。true表示必需授权，false表示可选授权或无需授权
        /// </summary>
        [XmlElement("need_auth")]
        public string NeedAuth { get; set; }
    }
}
