using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// LogisticsConsignOrderCreateandsendResponse.
    /// </summary>
    public class LogisticsConsignOrderCreateandsendResponse : TopResponse
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        [XmlElement("result_desc")]
        public string ResultDesc { get; set; }
    }
}
