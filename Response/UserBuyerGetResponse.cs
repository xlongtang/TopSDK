using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// UserBuyerGetResponse.
    /// </summary>
    public class UserBuyerGetResponse : TopResponse
    {
        /// <summary>
        /// 只返回nick,avatar参数
        /// </summary>
        [XmlElement("user")]
        public User User { get; set; }
    }
}
