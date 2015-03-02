using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemSchemaAddResponse.
    /// </summary>
    public class TmallItemSchemaAddResponse : TopResponse
    {
        /// <summary>
        /// 返回商品发布结果
        /// </summary>
        [XmlElement("add_item_result")]
        public string AddItemResult { get; set; }
    }
}
