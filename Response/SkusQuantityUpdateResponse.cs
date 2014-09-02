using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SkusQuantityUpdateResponse.
    /// </summary>
    public class SkusQuantityUpdateResponse : TopResponse
    {
        /// <summary>
        /// iid、numIid、num和modified，skus中每个sku的skuId、quantity和modified
        /// </summary>
        [XmlElement("item")]
        public Item Item { get; set; }
    }
}
