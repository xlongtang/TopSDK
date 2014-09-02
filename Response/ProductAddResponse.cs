using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ProductAddResponse.
    /// </summary>
    public class ProductAddResponse : TopResponse
    {
        /// <summary>
        /// 产品结构
        /// </summary>
        [XmlElement("product")]
        public Product Product { get; set; }
    }
}
