using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// WirelessBuntingShopShorturlCreateResponse.
    /// </summary>
    public class WirelessBuntingShopShorturlCreateResponse : TopResponse
    {
        /// <summary>
        /// 短链
        /// </summary>
        [XmlElement("shorturl")]
        public string Shorturl { get; set; }
    }
}
