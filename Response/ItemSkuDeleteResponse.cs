using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemSkuDeleteResponse.
    /// </summary>
    public class ItemSkuDeleteResponse : TopResponse
    {
        /// <summary>
        /// Sku结构
        /// </summary>
        [XmlElement("sku")]
        public Sku Sku { get; set; }
    }
}
