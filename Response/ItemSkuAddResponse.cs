using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ItemSkuAddResponse.
    /// </summary>
    public class ItemSkuAddResponse : TopResponse
    {
        /// <summary>
        /// sku
        /// </summary>
        [XmlElement("sku")]
        public Sku Sku { get; set; }
    }
}
