using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TmallRefundMessage Data Structure.
    /// </summary>
    [Serializable]
    public class TmallRefundMessage : TopObject
    {
        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 留言内容
        /// </summary>
        [XmlElement("message_content")]
        public string MessageContent { get; set; }

        /// <summary>
        /// 退款留言
        /// </summary>
        [XmlElement("message_id")]
        public long MessageId { get; set; }

        /// <summary>
        /// 退款单编号
        /// </summary>
        [XmlElement("refund_id")]
        public long RefundId { get; set; }

        /// <summary>
        /// onsale:售中  aftersale：售后
        /// </summary>
        [XmlElement("refund_phase")]
        public string RefundPhase { get; set; }

        /// <summary>
        /// 留言用户昵称
        /// </summary>
        [XmlElement("user_nick")]
        public string UserNick { get; set; }

        /// <summary>
        /// 留言用户角色
        /// </summary>
        [XmlElement("user_role")]
        public string UserRole { get; set; }

        /// <summary>
        /// 举证信息
        /// </summary>
        [XmlElement("voucher_urls")]
        public string VoucherUrls { get; set; }
    }
}
