using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightWordscatsGetResponse.
    /// </summary>
    public class SimbaInsightWordscatsGetResponse : TopResponse
    {
        /// <summary>
        /// 词和类目基础信息对象列表
        /// </summary>
        [XmlArray("in_word_categories")]
        [XmlArrayItem("i_n_word_category")]
        public List<INWordCategory> InWordCategories { get; set; }
    }
}
