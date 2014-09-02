using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WidgetLoginstatusGetResponse.
    /// </summary>
    public class WidgetLoginstatusGetResponse : TopResponse
    {
        /// <summary>
        /// 当前浏览器用户是否已登陆。如果指定了nick，但是nick与浏览器用户不一致返回false。如果未指定nick，以浏览器用户登陆状态为准。如果指定了nick且与浏览器用户一致，以浏览器用户登陆状态为准
        /// </summary>
        [XmlElement("is_login")]
        public bool IsLogin { get; set; }

        /// <summary>
        /// 淘宝用户的昵称，传了session且已登陆才返回
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 淘宝用户的数字id，传了session且已登录才返回。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
