using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Bill Data Structure.
    /// </summary>
    [Serializable]
    public class Bill : TopObject
    {
        /// <summary>
        /// 科目编号
        /// </summary>
        [XmlElement("account_id")]
        public long AccountId { get; set; }

        /// <summary>
        /// 支付宝账户编号
        /// </summary>
        [XmlElement("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// 支付宝账户名称
        /// </summary>
        [XmlElement("alipay_mail")]
        public string AlipayMail { get; set; }

        /// <summary>
        /// 支付宝交易号,暂不提供
        /// </summary>
        [XmlElement("alipay_no")]
        public string AlipayNo { get; set; }

        /// <summary>
        /// 支付宝备注
        /// </summary>
        [XmlElement("alipay_notice")]
        public string AlipayNotice { get; set; }

        /// <summary>
        /// 支付宝商户订单号
        /// </summary>
        [XmlElement("alipay_outno")]
        public string AlipayOutno { get; set; }

        /// <summary>
        /// 账单金额,退款时返回的是负数
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 账单编号
        /// </summary>
        [XmlElement("bid")]
        public long Bid { get; set; }

        /// <summary>
        /// 业务时间,订单交易完成的时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 记账时间
        /// </summary>
        [XmlElement("book_time")]
        public string BookTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 所属商品编号
        /// </summary>
        [XmlElement("num_iid")]
        public string NumIid { get; set; }

        /// <summary>
        /// 目标支付宝账户编号
        /// </summary>
        [XmlElement("obj_alipay_id")]
        public string ObjAlipayId { get; set; }

        /// <summary>
        /// 目标支付宝账户名称
        /// </summary>
        [XmlElement("obj_alipay_mail")]
        public string ObjAlipayMail { get; set; }

        /// <summary>
        /// 交易子订单编号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 支付时间,收取佣金时支付宝的扣款时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 0-未支付,1-支付成功,2-支付失败
        /// </summary>
        [XmlElement("status")]
        public long Status { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [XmlElement("total_amount")]
        public long TotalAmount { get; set; }

        /// <summary>
        /// 交易订单编号
        /// </summary>
        [XmlElement("trade_id")]
        public string TradeId { get; set; }
    }
}
