using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SellercenterSubuserPermissionsRolesGetResponse.
    /// </summary>
    public class SellercenterSubuserPermissionsRolesGetResponse : TopResponse
    {
        /// <summary>
        /// 子账号被所拥有的权限
        /// </summary>
        [XmlElement("subuser_permission")]
        public SubUserPermission SubuserPermission { get; set; }
    }
}
