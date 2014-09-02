using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaKeywordsChangedGetResponse.
    /// </summary>
    public class SimbaKeywordsChangedGetResponse : TopResponse
    {
        /// <summary>
        /// 关键词分页对象
        /// </summary>
        [XmlElement("keywords")]
        public KeywordPage Keywords { get; set; }
    }
}
