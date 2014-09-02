using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallProductSpecAddResponse.
    /// </summary>
    public class TmallProductSpecAddResponse : TopResponse
    {
        /// <summary>
        /// 产品规格对象
        /// </summary>
        [XmlElement("product_spec")]
        public ProductSpec ProductSpec { get; set; }
    }
}
