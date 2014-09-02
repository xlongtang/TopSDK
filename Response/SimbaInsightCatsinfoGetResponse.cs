using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightCatsinfoGetResponse.
    /// </summary>
    public class SimbaInsightCatsinfoGetResponse : TopResponse
    {
        /// <summary>
        /// 类目详细信息
        /// </summary>
        [XmlArray("category_info_list")]
        [XmlArrayItem("insight_category_info_d_t_o")]
        public List<InsightCategoryInfoDTO> CategoryInfoList { get; set; }
    }
}
