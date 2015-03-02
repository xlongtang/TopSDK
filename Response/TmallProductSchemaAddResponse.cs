using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallProductSchemaAddResponse.
    /// </summary>
    public class TmallProductSchemaAddResponse : TopResponse
    {
        /// <summary>
        /// 返回发布成功的产品ID
        /// </summary>
        [XmlElement("add_product_result")]
        public string AddProductResult { get; set; }
    }
}
