using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Location Data Structure.
    /// </summary>
    [Serializable]
    public class Location : TopObject
    {
        /// <summary>
        /// 详细地址，最大256个字节（128个中文）
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 所在城市（中文名称）
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 国家名称
        /// </summary>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// 区/县（只适用于物流API）
        /// </summary>
        [XmlElement("district")]
        public string District { get; set; }

        /// <summary>
        /// 所在省份（中文名称）
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        [XmlElement("zip")]
        public string Zip { get; set; }
    }
}
