using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// VideosSearchResponse.
    /// </summary>
    public class VideosSearchResponse : TopResponse
    {
        /// <summary>
        /// 搜索返回类，返回具体信息为入参fields请求的字段信息
        /// </summary>
        [XmlElement("search_result")]
        public TOPSearchResult SearchResult { get; set; }
    }
}
