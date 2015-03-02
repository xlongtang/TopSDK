using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// AppstoreSubscribeGetResponse.
    /// </summary>
    public class AppstoreSubscribeGetResponse : TopResponse
    {
        /// <summary>
        /// 用户订购信息
        /// </summary>
        [XmlElement("user_subscribe")]
        public UserSubscribe UserSubscribe { get; set; }
    }
}
