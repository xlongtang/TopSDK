using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// StoreInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StoreInfo : TopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// XXX果园
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 仓库真实名字
        /// </summary>
        [XmlElement("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 仓库服务代码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }
    }
}
