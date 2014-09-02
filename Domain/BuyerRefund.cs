using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// BuyerRefund Data Structure.
    /// </summary>
    [Serializable]
    public class BuyerRefund : TopObject
    {
        /// <summary>
        /// 订单id
        /// </summary>
        [XmlElement("biz_order_id")]
        public long BizOrderId { get; set; }

        /// <summary>
        /// 下游买家nick
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 货物的状态： 买家已收到货 买家已退货 买家未收到货
        /// </summary>
        [XmlElement("goods_status_desc")]
        public string GoodsStatusDesc { get; set; }

        /// <summary>
        /// 退款修改时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 买家是否退货
        /// </summary>
        [XmlElement("need_return_goods")]
        public bool NeedReturnGoods { get; set; }

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
        /// 交易退款id
        /// </summary>
        [XmlElement("refund_id")]
        public long RefundId { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("refund_status")]
        public long RefundStatus { get; set; }

        /// <summary>
        /// 退还买家的金额
        /// </summary>
        [XmlElement("return_fee")]
        public long ReturnFee { get; set; }

        /// <summary>
        /// 采购单子单id
        /// </summary>
        [XmlElement("sub_order_id")]
        public long SubOrderId { get; set; }

        /// <summary>
        /// 支付分销商的金额
        /// </summary>
        [XmlElement("to_seller_fee")]
        public long ToSellerFee { get; set; }
    }
}
