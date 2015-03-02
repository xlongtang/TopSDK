using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallProductAddSchemaGetResponse.
    /// </summary>
    public class TmallProductAddSchemaGetResponse : TopResponse
    {
        /// <summary>
        /// 返回发布产品的规则文档
        /// </summary>
        [XmlElement("add_product_rule")]
        public string AddProductRule { get; set; }
    }
}
