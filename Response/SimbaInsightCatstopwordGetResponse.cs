using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightCatstopwordGetResponse.
    /// </summary>
    public class SimbaInsightCatstopwordGetResponse : TopResponse
    {
        /// <summary>
        /// 类目TOP词查询
        /// </summary>
        [XmlArray("top_words")]
        [XmlArrayItem("string")]
        public List<string> TopWords { get; set; }
    }
}
