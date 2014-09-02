using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// WaimaiShopbycityGetResponse.
    /// </summary>
    public class WaimaiShopbycityGetResponse : TopResponse
    {
        /// <summary>
        /// 以city维度分的店铺list
        /// </summary>
        [XmlElement("result")]
        public ShopCityResult Result { get; set; }
    }
}
