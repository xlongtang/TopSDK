using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// IpAddress Data Structure.
    /// </summary>
    [Serializable]
    public class IpAddress : TopObject
    {
        /// <summary>
        /// Ip地址
        /// </summary>
        [XmlElement("IpAddress")]
        public string IpAddress_ { get; set; }
    }
}
