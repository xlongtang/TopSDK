using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// VSwitch Data Structure.
    /// </summary>
    [Serializable]
    public class VSwitch : TopObject
    {
        /// <summary>
        /// 虚拟交换机当前可用的IP地址数量
        /// </summary>
        [XmlElement("AvailableIpAddressCount")]
        public long AvailableIpAddressCount { get; set; }

        /// <summary>
        /// 虚拟交换机的地址
        /// </summary>
        [XmlElement("CidrBlock")]
        public string CidrBlock { get; set; }

        /// <summary>
        /// 创建时间。按照ISO8601标准表示，并需要使用UTC时间。格式为：  YYYY-MM-DDThh:mmZ
        /// </summary>
        [XmlElement("CreationTime")]
        public string CreationTime { get; set; }

        /// <summary>
        /// 描述，[1,256]英文或中文字符，不能以http://和https://开头。
        /// </summary>
        [XmlElement("Description")]
        public string Description { get; set; }

        /// <summary>
        /// 虚拟交换机状态，包括pending和Available两种
        /// </summary>
        [XmlElement("Status")]
        public string Status { get; set; }

        /// <summary>
        /// 虚拟交换机ID
        /// </summary>
        [XmlElement("VSwitchId")]
        public string VSwitchId { get; set; }

        /// <summary>
        /// 虚拟交换机名字，[1,128]英文或中文字符，不能以http://和https://开头。
        /// </summary>
        [XmlElement("VSwitchName")]
        public string VSwitchName { get; set; }

        /// <summary>
        /// 虚拟交换机所在的虚拟网络
        /// </summary>
        [XmlElement("VpcId")]
        public string VpcId { get; set; }

        /// <summary>
        /// 虚拟交换机所在的Zone
        /// </summary>
        [XmlElement("ZoneId")]
        public string ZoneId { get; set; }
    }
}
