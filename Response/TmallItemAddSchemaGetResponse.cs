using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemAddSchemaGetResponse.
    /// </summary>
    public class TmallItemAddSchemaGetResponse : TopResponse
    {
        /// <summary>
        /// 返回发布商品的规则文档
        /// </summary>
        [XmlElement("add_item_result")]
        public string AddItemResult { get; set; }
    }
}
