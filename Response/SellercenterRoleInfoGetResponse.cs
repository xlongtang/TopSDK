using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SellercenterRoleInfoGetResponse.
    /// </summary>
    public class SellercenterRoleInfoGetResponse : TopResponse
    {
        /// <summary>
        /// 角色具体信息
        /// </summary>
        [XmlElement("role")]
        public Role Role { get; set; }
    }
}
