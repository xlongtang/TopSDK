using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangEserviceNewloginlogsGetResponse.
    /// </summary>
    public class WangwangEserviceNewloginlogsGetResponse : TopResponse
    {
        /// <summary>
        /// 用户登录日志
        /// </summary>
        [XmlArray("userloginlogs")]
        [XmlArrayItem("user_loginlog")]
        public List<UserLoginlog> Userloginlogs { get; set; }
    }
}
