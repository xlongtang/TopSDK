using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaInsightCatsrelatedwordGetResponse.
    /// </summary>
    public class SimbaInsightCatsrelatedwordGetResponse : TopResponse
    {
        /// <summary>
        /// 类目相关词对象列表
        /// </summary>
        [XmlArray("related_words")]
        [XmlArrayItem("string")]
        public List<string> RelatedWords { get; set; }
    }
}
