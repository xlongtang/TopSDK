using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// AthenaItemSolutionGetResponse.
    /// </summary>
    public class AthenaItemSolutionGetResponse : TopResponse
    {
        /// <summary>
        /// 解决方案列表
        /// </summary>
        [XmlArray("item_solutions")]
        [XmlArrayItem("item_knowledge_solution_v_o")]
        public List<ItemKnowledgeSolutionVO> ItemSolutions { get; set; }
    }
}
