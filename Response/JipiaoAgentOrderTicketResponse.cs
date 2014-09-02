using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// JipiaoAgentOrderTicketResponse.
    /// </summary>
    public class JipiaoAgentOrderTicketResponse : TopResponse
    {
        /// <summary>
        /// 失败时的错误信息
        /// </summary>
        [XmlElement("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 返回接口调用完成后，整个订单是否成功
        /// </summary>
        [XmlElement("is_order_success")]
        public bool IsOrderSuccess { get; set; }

        /// <summary>
        /// 返回操作成功失败信息
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 返回回填票号操作成功失败信息
        /// </summary>
        [XmlElement("is_ticket_success")]
        public bool IsTicketSuccess { get; set; }
    }
}
