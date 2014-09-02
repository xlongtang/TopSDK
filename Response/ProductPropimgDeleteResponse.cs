using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// ProductPropimgDeleteResponse.
    /// </summary>
    public class ProductPropimgDeleteResponse : TopResponse
    {
        /// <summary>
        /// 返回product_prop_img数据结构中的：product_id,id
        /// </summary>
        [XmlElement("product_prop_img")]
        public ProductPropImg ProductPropImg { get; set; }
    }
}
