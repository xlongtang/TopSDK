using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Permission Data Structure.
    /// </summary>
    [Serializable]
    public class Permission : TopObject
    {
        /// <summary>
        /// 1 :允许授权  2：不允许授权 6：不允许授权但默认已有权限
        /// </summary>
        [XmlElement("is_authorize")]
        public long IsAuthorize { get; set; }

        /// <summary>
        /// 父权限code
        /// </summary>
        [XmlElement("parent_code")]
        public string ParentCode { get; set; }

        /// <summary>
        /// 注册到权限中心的code值
        /// </summary>
        [XmlElement("permission_code")]
        public string PermissionCode { get; set; }

        /// <summary>
        /// 权限名称
        /// </summary>
        [XmlElement("permission_name")]
        public string PermissionName { get; set; }
    }
}
