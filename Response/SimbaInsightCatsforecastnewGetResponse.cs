using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightCatsforecastnewGetResponse.
    /// </summary>
    public class SimbaInsightCatsforecastnewGetResponse : TopResponse
    {
        /// <summary>
        /// 词的相关类目列表
        /// </summary>
        [XmlArray("category_forecast_list")]
        [XmlArrayItem("insight_category_forcast_d_t_o")]
        public List<InsightCategoryForcastDTO> CategoryForecastList { get; set; }
    }
}
