using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightWordspricedataGetResponse.
    /// </summary>
    public class SimbaInsightWordspricedataGetResponse : TopResponse
    {
        /// <summary>
        /// 竞价区间分布数据
        /// </summary>
        [XmlArray("word_pricedata_list")]
        [XmlArrayItem("insight_word_price_distribute_data_d_t_o")]
        public List<InsightWordPriceDistributeDataDTO> WordPricedataList { get; set; }
    }
}
