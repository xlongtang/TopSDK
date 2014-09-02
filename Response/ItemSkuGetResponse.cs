using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemSkuGetResponse.
    /// </summary>
    public class ItemSkuGetResponse : TopResponse
    {
        /// <summary>
        /// Sku
        /// </summary>
        [XmlElement("sku")]
        public Sku Sku { get; set; }
    }
}
