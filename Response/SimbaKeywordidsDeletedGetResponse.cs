using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaKeywordidsDeletedGetResponse.
    /// </summary>
    public class SimbaKeywordidsDeletedGetResponse : TopResponse
    {
        /// <summary>
        /// 词ID列表
        /// </summary>
        [XmlArray("deleted_keyword_ids")]
        [XmlArrayItem("number")]
        public List<long> DeletedKeywordIds { get; set; }
    }
}
