using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemUpdateSchemaGetResponse.
    /// </summary>
    public class TmallItemUpdateSchemaGetResponse : TopResponse
    {
        /// <summary>
        /// 返回发布商品的规则文档
        /// </summary>
        [XmlElement("update_item_result")]
        public string UpdateItemResult { get; set; }
    }
}
