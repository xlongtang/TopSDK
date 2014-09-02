using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SellercenterRoleAddResponse.
    /// </summary>
    public class SellercenterRoleAddResponse : TopResponse
    {
        /// <summary>
        /// 子账号角色
        /// </summary>
        [XmlElement("role")]
        public Role Role { get; set; }
    }
}
