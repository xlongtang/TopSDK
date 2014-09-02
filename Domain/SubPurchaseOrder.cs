using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// SubPurchaseOrder Data Structure.
    /// </summary>
    [Serializable]
    public class SubPurchaseOrder : TopObject
    {
        /// <summary>
        /// 分销商店铺中宝贝一口价
        /// </summary>
        [XmlElement("auction_price")]
        public string AuctionPrice { get; set; }

        /// <summary>
        /// 发票应开金额。根据买家实际付款去除邮费后，按各个子单(商品)金额比例进行分摊后的金额，仅供开发票时做票面金额参考。
        /// </summary>
        [XmlElement("bill_fee")]
        public string BillFee { get; set; }

        /// <summary>
        /// 买家订单上对应的子单零售金额，除以num（数量）后等于最终宝贝的零售价格（精确到2位小数;单位:元。如:200.07，表示:200元7分）
        /// </summary>
        [XmlElement("buyer_payment")]
        public string BuyerPayment { get; set; }

        /// <summary>
        /// 创建时间。格式 yyyy-MM-dd HH:mm:ss 。
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 分销商实付金额=total_fee（分销商应付金额）+改价-优惠。（精确到2位小数;单位:元。如:200.07，表示:200元7分）
        /// </summary>
        [XmlElement("distributor_payment")]
        public string DistributorPayment { get; set; }

        /// <summary>
        /// 分销平台的子采购单主键
        /// </summary>
        [XmlElement("fenxiao_id")]
        public long FenxiaoId { get; set; }

        /// <summary>
        /// 子采购单id，淘宝交易主键，采购单未付款时为0.（只有支付宝 付款才有这个id，其余付款形式该字段为0）
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 分销平台上的产品id，同FenxiaoProduct 的pid
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 分销平台上商品商家编码。
        /// </summary>
        [XmlElement("item_outer_id")]
        public string ItemOuterId { get; set; }

        /// <summary>
        /// 产品的采购数量。取值范围:大于零的整数
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 老的SKU属性值。如: 颜色:红色:别名;尺码:L:别名
        /// </summary>
        [XmlElement("old_sku_properties")]
        public string OldSkuProperties { get; set; }

        /// <summary>
        /// 代销采购单对应下游200订单状态。  可选值：  WAIT_SELLER_SEND_GOODS(已付款，待发货)  WAIT_BUYER_CONFIRM_GOODS(已付款，已发货)  TRADE_CLOSED(已退款成功)  TRADE_REFUNDING(退款中)  TRADE_FINISHED(交易成功)  TRADE_CLOSED_BY_TAOBAO(交易关闭)
        /// </summary>
        [XmlElement("order_200_status")]
        public string Order200Status { get; set; }

        /// <summary>
        /// 产品的采购价格。（精确到2位小数;单位:元。如:200.07，表示:200元7分）
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 后端商品id
        /// </summary>
        [XmlElement("sc_item_id")]
        public long ScItemId { get; set; }

        /// <summary>
        /// 商品的SKU id。当存在时才会有值，建议使用sku_outer_id，sku_properties这两个值
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }

        /// <summary>
        /// SKU商家编码。
        /// </summary>
        [XmlElement("sku_outer_id")]
        public string SkuOuterId { get; set; }

        /// <summary>
        /// SKU属性值。如: 颜色:红色:别名;尺码:L:别名
        /// </summary>
        [XmlElement("sku_properties")]
        public string SkuProperties { get; set; }

        /// <summary>
        /// 快照地址。
        /// </summary>
        [XmlElement("snapshot_url")]
        public string SnapshotUrl { get; set; }

        /// <summary>
        /// 交易状态。可选值：<br> WAIT_BUYER_PAY(等待付款)<br> WAIT_CONFIRM(付款信息待确认)<br> WAIT_CONFIRM_WAIT_SEND_GOODS(付款信息待确认，待发货)<br> WAIT_CONFIRM_SEND_GOODS(付款信息待确认，已发货)<br> WAIT_CONFIRM_GOODS_CONFIRM(付款信息待确认，已收货)<br> WAIT_SELLER_SEND_GOODS(已付款，待发货)<br> WAIT_BUYER_CONFIRM_GOODS(已付款，已发货)<br> WAIT_BUYER_CONFIRM_GOODS_ACOUNTED(已付款（已分账），已发货。只对代销分账支持)<br> CONFIRM_WAIT_SEND_GOODS(付款信息已确认，待发货)<br> CONFIRM_SEND_GOODS(付款信息已确认，已发货)<br> TRADE_REFUNDED(已退款)<br> TRADE_REFUNDING(退款中)<br> TRADE_FINISHED(交易成功)<br> TRADE_CLOSED(交易关闭)<br> PAY_ACOUNTED_GOODS_CONFIRM （已分账发货成功）<br> PAY_WAIT_ACOUNT_GOODS_CONFIRM（已付款，确认收货）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商品的卖出金额调整，金额增加时为正数，金额减少时为负数，单位是分，不带小数
        /// </summary>
        [XmlElement("tc_adjust_fee")]
        public long TcAdjustFee { get; set; }

        /// <summary>
        /// 优惠金额，始终为正数，单位是分，不带小数
        /// </summary>
        [XmlElement("tc_discount_fee")]
        public long TcDiscountFee { get; set; }

        /// <summary>
        /// TC子订单ID（经销不显示）
        /// </summary>
        [XmlElement("tc_order_id")]
        public long TcOrderId { get; set; }

        /// <summary>
        /// 商品优惠类型：聚划算、秒杀或其他
        /// </summary>
        [XmlElement("tc_preferential_type")]
        public string TcPreferentialType { get; set; }

        /// <summary>
        /// 采购的产品标题。
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 分销商应付金额=num(采购数量)*price(采购价)。（精确到2位小数;单位:元。如:200.07，表示:200元7分）
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }
    }
}
