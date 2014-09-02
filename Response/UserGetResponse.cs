using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// UserGetResponse.
    /// </summary>
    public class UserGetResponse : TopResponse
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        [XmlElement("user")]
        public User User { get; set; }
    }
}
