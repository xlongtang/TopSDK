using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallPromotagTagFindResponse.
    /// </summary>
    public class TmallPromotagTagFindResponse : TopResponse
    {
        /// <summary>
        /// 查询结果类型
        /// </summary>
        [XmlElement("query_result")]
        public PromotionTagQuery QueryResult { get; set; }
    }
}
