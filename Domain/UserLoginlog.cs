using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// UserLoginlog Data Structure.
    /// </summary>
    [Serializable]
    public class UserLoginlog : TopObject
    {
        /// <summary>
        /// 用户登录日志的条数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 用户登录日志信息
        /// </summary>
        [XmlArray("loginlogs")]
        [XmlArrayItem("login_log")]
        public List<LoginLog> Loginlogs { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("uid")]
        public string Uid { get; set; }
    }
}
