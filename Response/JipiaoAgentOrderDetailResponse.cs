using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// JipiaoAgentOrderDetailResponse.
    /// </summary>
    public class JipiaoAgentOrderDetailResponse : TopResponse
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
        /// 机票订单的详情列表，当前支持返回一个订单
        /// </summary>
        [XmlArray("orders")]
        [XmlArrayItem("trip_order")]
        public List<TripOrder> Orders { get; set; }
    }
}
