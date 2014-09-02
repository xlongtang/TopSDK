using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightCatsGetResponse.
    /// </summary>
    public class SimbaInsightCatsGetResponse : TopResponse
    {
        /// <summary>
        /// 类目对象列表
        /// </summary>
        [XmlArray("in_category_tops")]
        [XmlArrayItem("i_n_category_top")]
        public List<INCategoryTop> InCategoryTops { get; set; }
    }
}
