using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaKeywordsQscoreGetResponse.
    /// </summary>
    public class SimbaKeywordsQscoreGetResponse : TopResponse
    {
        /// <summary>
        /// 取得的关键词质量得分列表
        /// </summary>
        [XmlArray("keyword_qscore_list")]
        [XmlArrayItem("keyword_qscore")]
        public List<KeywordQscore> KeywordQscoreList { get; set; }
    }
}
