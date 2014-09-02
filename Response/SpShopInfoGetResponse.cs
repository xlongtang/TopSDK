using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SpShopInfoGetResponse.
    /// </summary>
    public class SpShopInfoGetResponse : TopResponse
    {
        /// <summary>
        /// 店铺信息
        /// </summary>
        [XmlElement("shop")]
        public SpShop Shop { get; set; }
    }
}
