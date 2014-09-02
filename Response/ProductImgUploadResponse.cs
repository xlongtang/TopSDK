using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ProductImgUploadResponse.
    /// </summary>
    public class ProductImgUploadResponse : TopResponse
    {
        /// <summary>
        /// 返回产品图片结构中的：url,id,created,modified
        /// </summary>
        [XmlElement("product_img")]
        public ProductImg ProductImg { get; set; }
    }
}
