using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightRelatedwordsGetResponse.
    /// </summary>
    public class SimbaInsightRelatedwordsGetResponse : TopResponse
    {
        /// <summary>
        /// 相关词列表
        /// </summary>
        [XmlArray("related_words_result_list")]
        [XmlArrayItem("insight_related_words")]
        public List<InsightRelatedWords> RelatedWordsResultList { get; set; }
    }
}
