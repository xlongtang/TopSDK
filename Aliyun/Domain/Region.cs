using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// Region Data Structure.
    /// </summary>
    [Serializable]
    public class Region : TopObject
    {
        /// <summary>
        /// 地域名称
        /// </summary>
        [XmlElement("LocalName")]
        public string LocalName { get; set; }

        /// <summary>
        /// 地域Id
        /// </summary>
        [XmlElement("RegionId")]
        public string RegionId { get; set; }
    }
}
