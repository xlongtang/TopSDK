using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// JipiaoAgentOrderSearchResponse.
    /// </summary>
    public class JipiaoAgentOrderSearchResponse : TopResponse
    {
        /// <summary>
        /// 失败时的错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 返回操作成功失败信息
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 机票订单搜索返回结果对象
        /// </summary>
        [XmlElement("search_result")]
        public SearchOrderResult SearchResult { get; set; }
    }
}
