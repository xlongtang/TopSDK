using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// Role Data Structure.
    /// </summary>
    [Serializable]
    public class Role : TopObject
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 角色描述
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("modified_time")]
        public string ModifiedTime { get; set; }

        /// <summary>
        /// 所拥有权限
        /// </summary>
        [XmlArray("permissions")]
        [XmlArrayItem("permission")]
        public List<Permission> Permissions { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [XmlElement("role_id")]
        public long RoleId { get; set; }

        /// <summary>
        /// 角色名
        /// </summary>
        [XmlElement("role_name")]
        public string RoleName { get; set; }

        /// <summary>
        /// 卖家Id
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }
    }
}
