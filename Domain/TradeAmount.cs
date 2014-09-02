using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TradeAmount Data Structure.
    /// </summary>
    [Serializable]
    public class TradeAmount : TopObject
    {
        /// <summary>
        /// 支付宝交易号，如：2009112081173831
        /// </summary>
        [XmlElement("alipay_no")]
        public string AlipayNo { get; set; }

        /// <summary>
        /// 买家货到付款服务费。精确到2位小数;单位:元。如:12.07，表示:12元7分
        /// </summary>
        [XmlElement("buyer_cod_fee")]
        public string BuyerCodFee { get; set; }

        /// <summary>
        /// 买家获得积分,返点的积分。格式:100;单位:个
        /// </summary>
        [XmlElement("buyer_obtain_point_fee")]
        public long BuyerObtainPointFee { get; set; }

        /// <summary>
        /// 货到付款服务费。精确到2位小数;单位:元。如:12.07，表示:12元7分
        /// </summary>
        [XmlElement("cod_fee")]
        public string CodFee { get; set; }

        /// <summary>
        /// 交易佣金。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("commission_fee")]
        public string CommissionFee { get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 交易成功时间(更新交易状态为成功的同时更新)/确认收货时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 快递代收款。精确到2位小数;单位:元。如:212.07，表示:212元7分
        /// </summary>
        [XmlElement("express_agency_fee")]
        public string ExpressAgencyFee { get; set; }

        /// <summary>
        /// 子订单的帐务金额详情列表
        /// </summary>
        [XmlArray("order_amounts")]
        [XmlArrayItem("order_amount")]
        public List<OrderAmount> OrderAmounts { get; set; }

        /// <summary>
        /// 付款时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 主订单实付金额。精确到2位小数;单位:元。如:200.07，表示:200元7分，计算公式如下：  如果主订单只有一笔子订单 payment = 子订单的实付金额 + 货到付款服务费(如果是货到付款订单) - 主订单的系统级优惠；如果主订单有多笔子订单 payment = 各子订单的实付金额之和 + 货到付款服务费(如果是货到付款订单) + 邮费 - 主订单的系统级优惠
        /// </summary>
        [XmlElement("payment")]
        public string Payment { get; set; }

        /// <summary>
        /// 邮费。精确到2位小数;单位:元。如:200.07，表示:200元7分。目前只提供整笔交易的邮费，暂不提供各子订单的邮费
        /// </summary>
        [XmlElement("post_fee")]
        public string PostFee { get; set; }

        /// <summary>
        /// 主交易订单的系统级优惠详情
        /// </summary>
        [XmlArray("promotion_details")]
        [XmlArrayItem("promotion_detail")]
        public List<PromotionDetail> PromotionDetails { get; set; }

        /// <summary>
        /// 卖家货到付款服务费。精确到2位小数;单位:元。如:12.07，表示:12元7分
        /// </summary>
        [XmlElement("seller_cod_fee")]
        public string SellerCodFee { get; set; }

        /// <summary>
        /// 交易主订单编号
        /// </summary>
        [XmlElement("tid")]
        public long Tid { get; set; }

        /// <summary>
        /// 主订单的商品金额（各子订单中商品price * num的和，不包括任何优惠信息）。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }
    }
}
