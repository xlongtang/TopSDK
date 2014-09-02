using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// Qscore Data Structure.
    /// </summary>
    [Serializable]
    public class Qscore : TopObject
    {
        /// <summary>
        /// 类目出价质量得分
        /// </summary>
        [XmlElement("catmatch_qscore")]
        public string CatmatchQscore { get; set; }

        /// <summary>
        /// 词质量得分列表
        /// </summary>
        [XmlArray("keyword_qscore_list")]
        [XmlArrayItem("keyword_qscore")]
        public List<KeywordQscore> KeywordQscoreList { get; set; }
    }
}
