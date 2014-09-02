using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// Vpcs Data Structure.
    /// </summary>
    [Serializable]
    public class Vpcs : TopObject
    {
        /// <summary>
        /// 虚拟网络所在的地域
        /// </summary>
        [XmlElement("RegionId")]
        public string RegionId { get; set; }

        /// <summary>
        /// 虚拟网络状态，包括pending和Available两种
        /// </summary>
        [XmlElement("Status")]
        public string Status { get; set; }

        /// <summary>
        /// 虚拟网络ID
        /// </summary>
        [XmlElement("VpcId")]
        public string VpcId { get; set; }

        /// <summary>
        /// 虚拟网络名称，[1,128]英文或中文字符，不能以http://和https://开头。
        /// </summary>
        [XmlElement("VpcName")]
        public string VpcName { get; set; }
    }
}
