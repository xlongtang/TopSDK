using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WlbPartnerAddress Data Structure.
    /// </summary>
    [Serializable]
    public class WlbPartnerAddress : TopObject
    {
        /// <summary>
        /// 详细地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [XmlElement("borough")]
        public string Borough { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 省
        /// </summary>
        [XmlElement("province")]
        public string Province { get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [XmlElement("zip")]
        public string Zip { get; set; }
    }
}
