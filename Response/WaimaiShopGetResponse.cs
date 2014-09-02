using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WaimaiShopGetResponse.
    /// </summary>
    public class WaimaiShopGetResponse : TopResponse
    {
        /// <summary>
        /// 外卖店信息
        /// </summary>
        [XmlElement("result")]
        public TakeoutShop Result { get; set; }
    }
}
