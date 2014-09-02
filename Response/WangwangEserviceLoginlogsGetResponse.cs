using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WangwangEserviceLoginlogsGetResponse.
    /// </summary>
    public class WangwangEserviceLoginlogsGetResponse : TopResponse
    {
        /// <summary>
        /// 在指定时间段登录日志的条数
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 登录日志具体信息
        /// </summary>
        [XmlArray("loginlogs")]
        [XmlArrayItem("login_log")]
        public List<LoginLog> Loginlogs { get; set; }

        /// <summary>
        /// 被查询的用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
