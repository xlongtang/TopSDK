using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// EbookSignStatus Data Structure.
    /// </summary>
    [Serializable]
    public class EbookSignStatus : TopObject
    {
        /// <summary>
        /// 是否签约
        /// </summary>
        [XmlElement("sign")]
        public bool Sign { get; set; }

        /// <summary>
        /// 签约地址
        /// </summary>
        [XmlElement("sign_url")]
        public string SignUrl { get; set; }
    }
}
