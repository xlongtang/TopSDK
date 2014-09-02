using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SellercenterRolesGetResponse.
    /// </summary>
    public class SellercenterRolesGetResponse : TopResponse
    {
        /// <summary>
        /// 卖家子账号角色列表。<br/>返回对象为 role数据对象中的role_id，role_name，description，seller_id，create_time，modified_time。不包含permissions(权限点)
        /// </summary>
        [XmlArray("roles")]
        [XmlArrayItem("role")]
        public List<Role> Roles { get; set; }
    }
}
