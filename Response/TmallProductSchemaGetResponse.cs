using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallProductSchemaGetResponse.
    /// </summary>
    public class TmallProductSchemaGetResponse : TopResponse
    {
        /// <summary>
        /// 产品信息数据。schema形式
        /// </summary>
        [XmlElement("get_product_result")]
        public string GetProductResult { get; set; }
    }
}
