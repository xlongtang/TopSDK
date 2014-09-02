using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// UserThirdAddress Data Structure.
    /// </summary>
    [Serializable]
    public class UserThirdAddress : TopObject
    {
        /// <summary>
        /// 送货地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 买家姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [XmlElement("phone")]
        public string Phone { get; set; }
    }
}
