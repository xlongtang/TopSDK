using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// AthenaItemKnowledgeTypeGetResponse.
    /// </summary>
    public class AthenaItemKnowledgeTypeGetResponse : TopResponse
    {
        /// <summary>
        /// 宝贝自定义问题列表
        /// </summary>
        [XmlArray("item_knowledge_type_list")]
        [XmlArrayItem("item_knowledge_type")]
        public List<ItemKnowledgeType> ItemKnowledgeTypeList { get; set; }
    }
}
