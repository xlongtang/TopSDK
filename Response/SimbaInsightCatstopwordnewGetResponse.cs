using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightCatstopwordnewGetResponse.
    /// </summary>
    public class SimbaInsightCatstopwordnewGetResponse : TopResponse
    {
        /// <summary>
        /// 类目下热门词详细数据
        /// </summary>
        [XmlArray("topword_data_list")]
        [XmlArrayItem("insight_word_data_under_cat_d_t_o")]
        public List<InsightWordDataUnderCatDTO> TopwordDataList { get; set; }
    }
}
