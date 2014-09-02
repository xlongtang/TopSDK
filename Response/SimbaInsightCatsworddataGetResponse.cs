using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightCatsworddataGetResponse.
    /// </summary>
    public class SimbaInsightCatsworddataGetResponse : TopResponse
    {
        /// <summary>
        /// 关键词在类目下的数据
        /// </summary>
        [XmlArray("catword_data_list")]
        [XmlArrayItem("insight_word_data_under_cat_d_t_o")]
        public List<InsightWordDataUnderCatDTO> CatwordDataList { get; set; }
    }
}
