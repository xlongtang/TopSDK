using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// Permission Data Structure.
    /// </summary>
    [Serializable]
    public class Permission : TopObject
    {
        /// <summary>
        /// IP协议
        /// </summary>
        [XmlElement("IpProtocol")]
        public string IpProtocol { get; set; }

        /// <summary>
        /// 网络类型
        /// </summary>
        [XmlElement("NicType")]
        public string NicType { get; set; }

        /// <summary>
        /// 授权策略
        /// </summary>
        [XmlElement("Policy")]
        public string Policy { get; set; }

        /// <summary>
        /// 授权指定的端口范围
        /// </summary>
        [XmlElement("PortRange")]
        public string PortRange { get; set; }

        /// <summary>
        /// 授权给指定IP地址段
        /// </summary>
        [XmlElement("SourceCidrIp")]
        public string SourceCidrIp { get; set; }

        /// <summary>
        /// 源安全组编码
        /// </summary>
        [XmlElement("SourceGroupId")]
        public string SourceGroupId { get; set; }
    }
}
