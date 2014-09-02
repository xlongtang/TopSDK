using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightWordssubdataGetResponse.
    /// </summary>
    public class SimbaInsightWordssubdataGetResponse : TopResponse
    {
        /// <summary>
        /// 关键词按流量细分的数据
        /// </summary>
        [XmlArray("word_subdata_list")]
        [XmlArrayItem("insight_word_sub_data_d_t_o")]
        public List<InsightWordSubDataDTO> WordSubdataList { get; set; }
    }
}
