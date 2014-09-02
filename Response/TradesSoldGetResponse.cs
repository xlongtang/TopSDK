using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// TradesSoldGetResponse.
    /// </summary>
    public class TradesSoldGetResponse : TopResponse
    {
        /// <summary>
        /// 是否存在下一页
        /// </summary>
        [XmlElement("has_next")]
        public bool HasNext { get; set; }

        /// <summary>
        /// 搜索到的交易信息总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }

        /// <summary>
        /// 搜索到的交易信息列表，返回的Trade和Order中包含的具体信息为入参fields请求的字段信息
        /// </summary>
        [XmlArray("trades")]
        [XmlArrayItem("trade")]
        public List<Trade> Trades { get; set; }
    }
}
