using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// SecurityGroup Data Structure.
    /// </summary>
    [Serializable]
    public class SecurityGroup : TopObject
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("CreationTime")]
        public string CreationTime { get; set; }

        /// <summary>
        /// 安全组描述信息
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 安全组ID
        /// </summary>
        [XmlElement("SecurityGroupId")]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// 安全组名称，不填则为空，默认值为空
        /// </summary>
        [XmlElement("SecurityGroupName")]
        public string SecurityGroupName { get; set; }

        /// <summary>
        /// 虚拟专有网络Id
        /// </summary>
        [XmlElement("VpcId")]
        public string VpcId { get; set; }
    }
}
