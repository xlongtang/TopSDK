using System;
using System.Xml.Serialization;
using Aliyun.Api;
using System.Collections.Generic;
using Aliyun.Api.Domain;

namespace Aliyun.Api.ECS.ECS20130110.Response
{
    /// <summary>
    /// DescribeSecurityGroupAttributeResponse.
    /// </summary>
    public class DescribeSecurityGroupAttributeResponse : AliyunResponse
    {
        /// <summary>
        /// 安全组描述信息
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 安全组中的权限规则列表
        /// </summary>
        [XmlArray("Permissions")]
        [XmlArrayItem("Permission")]
        public List<Permission> Permissions { get; set; }

        /// <summary>
        /// 地域Id
        /// </summary>
        [XmlElement("RegionId")]
        public string RegionId { get; set; }

        /// <summary>
        /// 请求的唯一ID，系统自动生成
        /// </summary>
        [XmlElement("RequestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// 安全组名称
        /// </summary>
        [XmlElement("SecurityGroupId")]
        public string SecurityGroupId { get; set; }
    }
}
