using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// RefundBill Data Structure.
    /// </summary>
    [Serializable]
    public class RefundBill : TopObject
    {
        /// <summary>
        /// 实际退款金额
        /// </summary>
        [XmlElement("actual_refund_fee")]
        public long ActualRefundFee { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("alipay_no")]
        public string AlipayNo { get; set; }

        /// <summary>
        /// 扩展属性
        /// </summary>
        [XmlElement("attribute")]
        public string Attribute { get; set; }

        /// <summary>
        /// 单据类型，退款单
        /// </summary>
        [XmlElement("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 买家昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 退款创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 淘宝小二是否介入
        /// </summary>
        [XmlElement("cs_status")]
        public string CsStatus { get; set; }

        /// <summary>
        /// 当前状态超时时间
        /// </summary>
        [XmlElement("current_phase_timeout")]
        public string CurrentPhaseTimeout { get; set; }

        /// <summary>
        /// 退款说明
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 退款商品信息
        /// </summary>
        [XmlArray("item_list")]
        [XmlArrayItem("refund_item")]
        public List<RefundItem> ItemList { get; set; }

        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 交易子订单号
        /// </summary>
        [XmlElement("oid")]
        public long Oid { get; set; }

        /// <summary>
        /// cannot_refuse: 不允许操作  refund_onweb: 需要到网页版操作
        /// </summary>
        [XmlElement("operation_constraint")]
        public string OperationConstraint { get; set; }

        /// <summary>
        /// 申请退款原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 申请退款金额，单位：分
        /// </summary>
        [XmlElement("refund_fee")]
        public long RefundFee { get; set; }

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
        /// refund:仅退款  return:退款退货
        /// </summary>
        [XmlElement("refund_type")]
        public string RefundType { get; set; }

        /// <summary>
        /// 退款协议版本
        /// </summary>
        [XmlElement("refund_version")]
        public long RefundVersion { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 退款单 状态  wait_seller_agree：买家申请，等待卖家同意  seller_refuse：卖家拒绝  goods_returning：退货中  closed：退款失败  success：退款成功
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 退款单的相关标签信息
        /// </summary>
        [XmlArray("tag_list")]
        [XmlArrayItem("tag")]
        public List<Tag> TagList { get; set; }

        /// <summary>
        /// 交易主订单号
        /// </summary>
        [XmlElement("tid")]
        public long Tid { get; set; }

        /// <summary>
        /// wait_send_good:等待卖家发货  wait_confirm_good：卖家已发货，等待买家确认收货  finish: 交易完成
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }
    }
}
