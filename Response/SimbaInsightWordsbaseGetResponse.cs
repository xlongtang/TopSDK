using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightWordsbaseGetResponse.
    /// </summary>
    public class SimbaInsightWordsbaseGetResponse : TopResponse
    {
        /// <summary>
        /// 词基础数据对象列表
        /// </summary>
        [XmlArray("in_word_bases")]
        [XmlArrayItem("i_n_word_base")]
        public List<INWordBase> InWordBases { get; set; }
    }
}
