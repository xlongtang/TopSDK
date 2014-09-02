using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightWordsdataGetResponse.
    /// </summary>
    public class SimbaInsightWordsdataGetResponse : TopResponse
    {
        /// <summary>
        /// 关键词大盘数据列表
        /// </summary>
        [XmlArray("word_data_list")]
        [XmlArrayItem("insight_word_data_d_t_o")]
        public List<InsightWordDataDTO> WordDataList { get; set; }
    }
}
