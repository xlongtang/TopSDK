using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallItemSchemaIncrementUpdateResponse.
    /// </summary>
    public class TmallItemSchemaIncrementUpdateResponse : TopResponse
    {
        /// <summary>
        /// 返回商品发布结果
        /// </summary>
        [XmlElement("update_item_result")]
        public string UpdateItemResult { get; set; }
    }
}
