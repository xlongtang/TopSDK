using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TripJipiaoAgentOrderSearchResponse.
    /// </summary>
    public class TripJipiaoAgentOrderSearchResponse : TopResponse
    {
        /// <summary>
        /// 国内机票订单搜索返回结果对象
        /// </summary>
        [XmlElement("search_result")]
        public SearchOrderResult SearchResult { get; set; }
    }
}
