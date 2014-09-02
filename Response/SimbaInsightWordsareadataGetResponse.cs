using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightWordsareadataGetResponse.
    /// </summary>
    public class SimbaInsightWordsareadataGetResponse : TopResponse
    {
        /// <summary>
        /// 地域细分数据
        /// </summary>
        [XmlArray("word_areadata_list")]
        [XmlArrayItem("insight_words_area_distribute_data_d_t_o")]
        public List<InsightWordsAreaDistributeDataDTO> WordAreadataList { get; set; }
    }
}
