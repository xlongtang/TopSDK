using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaCustomersAuthorizedGetResponse.
    /// </summary>
    public class SimbaCustomersAuthorizedGetResponse : TopResponse
    {
        /// <summary>
        /// 授权当前登录账户为代理账户的昵称列表
        /// </summary>
        [XmlArray("nicks")]
        [XmlArrayItem("string")]
        public List<string> Nicks { get; set; }
    }
}
