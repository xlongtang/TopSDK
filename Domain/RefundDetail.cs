using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// RefundDetail Data Structure.
    /// </summary>
    [Serializable]
    public class RefundDetail : TopObject
    {
        /// <summary>
        /// 下游买家的退款信息
        /// </summary>
        [XmlElement("buyer_refund")]
        public BuyerRefund BuyerRefund { get; set; }

        /// <summary>
        /// 分销商nick
        /// </summary>
        [XmlElement("distributor_nick")]
        public string DistributorNick { get; set; }

        /// <summary>
        /// 是否退货
        /// </summary>
        [XmlElement("is_return_goods")]
        public bool IsReturnGoods { get; set; }

        /// <summary>
        /// 退款修改时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 支付给供应商的金额
        /// </summary>
        [XmlElement("pay_sup_fee")]
        public string PaySupFee { get; set; }

        /// <summary>
        /// 退款创建时间
        /// </summary>
        [XmlElement("refund_create_time")]
        public string RefundCreateTime { get; set; }

        /// <summary>
        /// 退款说明
        /// </summary>
        [XmlElement("refund_desc")]
        public string RefundDesc { get; set; }

        /// <summary>
        /// 退款的金额
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款状态  1：买家已经申请退款，等待卖家同意  2：卖家已经同意退款，等待买家退货  3：买家已经退货，等待卖家确认收货  4：退款关闭  5：退款成功  6：卖家拒绝退款  12：同意退款，待打款  9：没有申请退款
        /// </summary>
        [XmlElement("refund_status")]
        public long RefundStatus { get; set; }

        /// <summary>
        /// 子单id
        /// </summary>
        [XmlElement("sub_order_id")]
        public long SubOrderId { get; set; }

        /// <summary>
        /// 供应商nick
        /// </summary>
        [XmlElement("supplier_nick")]
        public string SupplierNick { get; set; }
    }
}
