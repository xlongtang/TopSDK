using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaKeywordKeywordforecastGetResponse.
    /// </summary>
    public class SimbaKeywordKeywordforecastGetResponse : TopResponse
    {
        /// <summary>
        /// 词预估结果信息    预测数据皆为估算结果，以实际发生为准
        /// </summary>
        [XmlElement("keyword_forecast")]
        public KeywordForecast KeywordForecast { get; set; }
    }
}
