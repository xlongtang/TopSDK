using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemIncrementUpdateSchemaGetResponse.
    /// </summary>
    public class TmallItemIncrementUpdateSchemaGetResponse : TopResponse
    {
        /// <summary>
        /// 返回增量更新商品的规则文档
        /// </summary>
        [XmlElement("update_item_result")]
        public string UpdateItemResult { get; set; }
    }
}
