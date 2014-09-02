using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// InstanceStatus Data Structure.
    /// </summary>
    [Serializable]
    public class InstanceStatus : TopObject
    {
        /// <summary>
        /// 实例ID
        /// </summary>
        [XmlElement("InstanceId")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [XmlElement("Status")]
        public string Status { get; set; }
    }
}
