using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightCatsdataGetResponse.
    /// </summary>
    public class SimbaInsightCatsdataGetResponse : TopResponse
    {
        /// <summary>
        /// 类目详细数据列表
        /// </summary>
        [XmlArray("cat_data_list")]
        [XmlArrayItem("insight_category_data_d_t_o")]
        public List<InsightCategoryDataDTO> CatDataList { get; set; }
    }
}
