using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// FenxiaoLoginUserGetResponse.
    /// </summary>
    public class FenxiaoLoginUserGetResponse : TopResponse
    {
        /// <summary>
        /// 登录用户信息
        /// </summary>
        [XmlElement("login_user")]
        public LoginUser LoginUser { get; set; }
    }
}
