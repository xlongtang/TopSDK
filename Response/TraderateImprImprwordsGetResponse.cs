using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// TraderateImprImprwordsGetResponse.
    /// </summary>
    public class TraderateImprImprwordsGetResponse : TopResponse
    {
        /// <summary>
        /// 返回类目下所有大家印象的标签
        /// </summary>
        [XmlArray("impr_words")]
        [XmlArrayItem("string")]
        public List<string> ImprWords { get; set; }
    }
}
