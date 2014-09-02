using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// InsightRelatedWords Data Structure.
    /// </summary>
    [Serializable]
    public class InsightRelatedWords : TopObject
    {
        /// <summary>
        /// 原词
        /// </summary>
        [XmlElement("bidword")]
        public string Bidword { get; set; }

        /// <summary>
        /// 相关词信息列表
        /// </summary>
        [XmlArray("related_word_items_list")]
        [XmlArrayItem("insight_related_word")]
        public List<InsightRelatedWord> RelatedWordItemsList { get; set; }
    }
}
