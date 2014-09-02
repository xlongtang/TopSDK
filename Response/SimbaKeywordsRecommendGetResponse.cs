using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// SimbaKeywordsRecommendGetResponse.
    /// </summary>
    public class SimbaKeywordsRecommendGetResponse : TopResponse
    {
        /// <summary>
        /// 推荐词分页对象，当输入的页码大于最大数值时，将返回最大的page_no值，并且结果中的数据列表为空值
        /// </summary>
        [XmlElement("recommend_words")]
        public RecommendWordPage RecommendWords { get; set; }
    }
}
