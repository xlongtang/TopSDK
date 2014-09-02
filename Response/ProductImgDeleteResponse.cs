using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ProductImgDeleteResponse.
    /// </summary>
    public class ProductImgDeleteResponse : TopResponse
    {
        /// <summary>
        /// 返回productimg中的：id,product_id
        /// </summary>
        [XmlElement("product_img")]
        public ProductImg ProductImg { get; set; }
    }
}
