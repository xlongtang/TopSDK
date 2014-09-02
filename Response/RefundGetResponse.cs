using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// RefundGetResponse.
    /// </summary>
    public class RefundGetResponse : TopResponse
    {
        /// <summary>
        /// 搜索到的交易信息列表
        /// </summary>
        [XmlElement("refund")]
        public Refund Refund { get; set; }
    }
}
