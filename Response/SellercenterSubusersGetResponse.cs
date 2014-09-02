using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SellercenterSubusersGetResponse.
    /// </summary>
    public class SellercenterSubusersGetResponse : TopResponse
    {
        /// <summary>
        /// 子账号基本信息列表。具体信息为id、子账号用户名、主账号id、主账号昵称、当前状态值、是否分流
        /// </summary>
        [XmlArray("subusers")]
        [XmlArrayItem("sub_user_info")]
        public List<SubUserInfo> Subusers { get; set; }
    }
}
