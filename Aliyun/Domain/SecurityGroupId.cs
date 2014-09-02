using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// SecurityGroupId Data Structure.
    /// </summary>
    [Serializable]
    public class SecurityGroupId : TopObject
    {
        /// <summary>
        /// 安全组ID
        /// </summary>
        [XmlElement("SecurityGroupId")]
        public string SecurityGroupId_ { get; set; }
    }
}
