using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaKeywordidsChangedGetResponse.
    /// </summary>
    public class SimbaKeywordidsChangedGetResponse : TopResponse
    {
        /// <summary>
        /// 词的ID列表
        /// </summary>
        [XmlArray("changed_keyword_ids")]
        [XmlArrayItem("number")]
        public List<long> ChangedKeywordIds { get; set; }
    }
}
