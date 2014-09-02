using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaKeywordRankingforecastGetResponse.
    /// </summary>
    public class SimbaKeywordRankingforecastGetResponse : TopResponse
    {
        /// <summary>
        /// 词预估结果信息    预测数据皆为估算结果，以实际发生为准
        /// </summary>
        [XmlArray("keyword_ranking_forecast")]
        [XmlArrayItem("rankingforecast")]
        public List<Rankingforecast> KeywordRankingForecast { get; set; }
    }
}
