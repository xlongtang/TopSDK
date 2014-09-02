using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaKeywordsbyadgroupidGetResponse.
    /// </summary>
    public class SimbaKeywordsbyadgroupidGetResponse : TopResponse
    {
        /// <summary>
        /// 取得的关键词列表
        /// </summary>
        [XmlArray("keywords")]
        [XmlArrayItem("keyword")]
        public List<Keyword> Keywords { get; set; }
    }
}
