using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightCatsanalysisGetResponse.
    /// </summary>
    public class SimbaInsightCatsanalysisGetResponse : TopResponse
    {
        /// <summary>
        /// 词分析数据列表
        /// </summary>
        [XmlArray("in_category_analyses")]
        [XmlArrayItem("i_n_category_analysis")]
        public List<INCategoryAnalysis> InCategoryAnalyses { get; set; }
    }
}
