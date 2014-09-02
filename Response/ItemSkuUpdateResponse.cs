using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemSkuUpdateResponse.
    /// </summary>
    public class ItemSkuUpdateResponse : TopResponse
    {
        /// <summary>
        /// 商品Sku
        /// </summary>
        [XmlElement("sku")]
        public Sku Sku { get; set; }
    }
}
