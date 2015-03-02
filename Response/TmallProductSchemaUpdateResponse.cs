using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallProductSchemaUpdateResponse.
    /// </summary>
    public class TmallProductSchemaUpdateResponse : TopResponse
    {
        /// <summary>
        /// 产品数据，格式和入参xml_data一致，仅包含产品ID和更新时间
        /// </summary>
        [XmlElement("update_product_result")]
        public string UpdateProductResult { get; set; }
    }
}
