using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaKeywordscatQscoreGetResponse.
    /// </summary>
    public class SimbaKeywordscatQscoreGetResponse : TopResponse
    {
        /// <summary>
        /// 类目出价和词的质量得分对象
        /// </summary>
        [XmlElement("qscore")]
        public Qscore Qscore { get; set; }
    }
}
