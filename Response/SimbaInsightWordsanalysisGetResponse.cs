using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightWordsanalysisGetResponse.
    /// </summary>
    public class SimbaInsightWordsanalysisGetResponse : TopResponse
    {
        /// <summary>
        /// 词分析列表
        /// </summary>
        [XmlArray("in_word_analyses")]
        [XmlArrayItem("i_n_word_analysis")]
        public List<INWordAnalysis> InWordAnalyses { get; set; }
    }
}
