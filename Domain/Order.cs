using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Order Data Structure.
    /// </summary>
    [Serializable]
    public class Order : TopObject
    {
        /// <summary>
        /// 手工调整金额.格式为:1.01;单位:元;精确到小数点后两位.
        /// </summary>
        [XmlElement("adjust_fee")]
        public string AdjustFee { get; set; }

        /// <summary>
        /// 捆绑的子订单号，表示该子订单要和捆绑的子订单一起发货，用于卖家子订单捆绑发货
        /// </summary>
        [XmlElement("bind_oid")]
        public long BindOid { get; set; }

        /// <summary>
        /// 买家昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 买家是否已评价。可选值：true(已评价)，false(未评价)
        /// </summary>
        [XmlElement("buyer_rate")]
        public bool BuyerRate { get; set; }

        /// <summary>
        /// 交易商品对应的类目ID
        /// </summary>
        [XmlElement("cid")]
        public long Cid { get; set; }

        /// <summary>
        /// 子订单发货时间，当卖家对订单进行了多次发货，子订单的发货时间和主订单的发货时间可能不一样了，那么就需要以子订单的时间为准。（没有进行多次发货的订单，主订单的发货时间和子订单的发货时间都一样）
        /// </summary>
        [XmlElement("consign_time")]
        public string ConsignTime { get; set; }

        /// <summary>
        /// 订单优惠金额。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("discount_fee")]
        public string DiscountFee { get; set; }

        /// <summary>
        /// 分摊之后的实付金额
        /// </summary>
        [XmlElement("divide_order_fee")]
        public string DivideOrderFee { get; set; }

        /// <summary>
        /// 子订单的交易结束时间  说明：子订单有单独的结束时间，与主订单的结束时间可能有所不同，在有退款发起的时候或者是主订单分阶段付款的时候，子订单的结束时间会早于主订单的结束时间，所以开放这个字段便于订单结束状态的判断
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商品的字符串编号(注意：iid近期即将废弃，请用num_iid参数)
        /// </summary>
        [XmlElement("iid")]
        public string Iid { get; set; }

        /// <summary>
        /// 子订单所在包裹的运单号
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 表示订单交易是否含有对应的代销采购单。  如果该订单中存在一个对应的代销采购单，那么该值为true；反之，该值为false。
        /// </summary>
        [XmlElement("is_daixiao")]
        public bool IsDaixiao { get; set; }

        /// <summary>
        /// 是否超卖
        /// </summary>
        [XmlElement("is_oversold")]
        public bool IsOversold { get; set; }

        /// <summary>
        /// 是否是服务订单，是返回true，否返回false。
        /// </summary>
        [XmlElement("is_service_order")]
        public bool IsServiceOrder { get; set; }

        /// <summary>
        /// 套餐ID
        /// </summary>
        [XmlElement("item_meal_id")]
        public long ItemMealId { get; set; }

        /// <summary>
        /// 套餐的值。如：M8原装电池:便携支架:M8专用座充:莫凡保护袋
        /// </summary>
        [XmlElement("item_meal_name")]
        public string ItemMealName { get; set; }

        /// <summary>
        /// 子订单发货的快递公司名称
        /// </summary>
        [XmlElement("logistics_company")]
        public string LogisticsCompany { get; set; }

        /// <summary>
        /// 订单修改时间，目前只有taobao.trade.ordersku.update会返回此字段。
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 购买数量。取值范围:大于零的整数
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 商品数字ID
        /// </summary>
        [XmlElement("num_iid")]
        public long NumIid { get; set; }

        /// <summary>
        /// 子订单编号
        /// </summary>
        [XmlElement("oid")]
        public long Oid { get; set; }

        /// <summary>
        /// 子订单来源,如jhs(聚划算)、taobao(淘宝)、wap(无线)
        /// </summary>
        [XmlElement("order_from")]
        public string OrderFrom { get; set; }

        /// <summary>
        /// 商家外部编码(可与商家外部系统对接)。外部商家自己定义的商品Item的id，可以通过taobao.items.custom.get获取商品的Item的信息
        /// </summary>
        [XmlElement("outer_iid")]
        public string OuterIid { get; set; }

        /// <summary>
        /// 外部网店自己定义的Sku编号
        /// </summary>
        [XmlElement("outer_sku_id")]
        public string OuterSkuId { get; set; }

        /// <summary>
        /// 优惠分摊
        /// </summary>
        [XmlElement("part_mjz_discount")]
        public string PartMjzDiscount { get; set; }

        /// <summary>
        /// 子订单实付金额。精确到2位小数，单位:元。如:200.07，表示:200元7分。计算公式如下：payment = price * num + adjust_fee - discount_fee + post_fee(邮费，单笔子订单时子订单实付金额包含邮费，多笔子订单时不包含邮费)；对于退款成功的子订单，由于主订单的优惠分摊金额，会造成该字段可能不为0.00元。建议使用退款前的实付金额减去退款单中的实际退款金额计算。
        /// </summary>
        [XmlElement("payment")]
        public string Payment { get; set; }

        /// <summary>
        /// 商品图片的绝对路径
        /// </summary>
        [XmlElement("pic_path")]
        public string PicPath { get; set; }

        /// <summary>
        /// 商品价格。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 最近退款ID
        /// </summary>
        [XmlElement("refund_id")]
        public long RefundId { get; set; }

        /// <summary>
        /// 退款状态。退款状态。可选值 WAIT_SELLER_AGREE(买家已经申请退款，等待卖家同意) WAIT_BUYER_RETURN_GOODS(卖家已经同意退款，等待买家退货) WAIT_SELLER_CONFIRM_GOODS(买家已经退货，等待卖家确认收货) SELLER_REFUSE_BUYER(卖家拒绝退款) CLOSED(退款关闭) SUCCESS(退款成功)
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 卖家是否已评价。可选值：true(已评价)，false(未评价)
        /// </summary>
        [XmlElement("seller_rate")]
        public bool SellerRate { get; set; }

        /// <summary>
        /// 卖家类型，可选值为：B（商城商家），C（普通卖家）
        /// </summary>
        [XmlElement("seller_type")]
        public string SellerType { get; set; }

        /// <summary>
        /// 子订单的运送方式（卖家对订单进行多次发货之后，一个主订单下的子订单的运送方式可能不同，用order.shipping_type来区分子订单的运送方式）
        /// </summary>
        [XmlElement("shipping_type")]
        public string ShippingType { get; set; }

        /// <summary>
        /// 商品的最小库存单位Sku的id.可以通过taobao.item.sku.get获取详细的Sku信息
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// SKU的值。如：机身颜色:黑色;手机套餐:官方标配
        /// </summary>
        [XmlElement("sku_properties_name")]
        public string SkuPropertiesName { get; set; }

        /// <summary>
        /// 订单快照详细信息
        /// </summary>
        [XmlElement("snapshot")]
        public string Snapshot { get; set; }

        /// <summary>
        /// 订单快照URL
        /// </summary>
        [XmlElement("snapshot_url")]
        public string SnapshotUrl { get; set; }

        /// <summary>
        /// 订单状态（请关注此状态，如果为TRADE_CLOSED_BY_TAOBAO状态，则不要对此订单进行发货，切记啊！）。可选值:   <ul>  <li>TRADE_NO_CREATE_PAY(没有创建支付宝交易)   <li>WAIT_BUYER_PAY(等待买家付款)   <li>WAIT_SELLER_SEND_GOODS(等待卖家发货,即:买家已付款)   <li>WAIT_BUYER_CONFIRM_GOODS(等待买家确认收货,即:卖家已发货)   <li>TRADE_BUYER_SIGNED(买家已签收,货到付款专用)   <li>TRADE_FINISHED(交易成功)   <li>TRADE_CLOSED(付款以后用户退款成功，交易自动关闭)   <li>TRADE_CLOSED_BY_TAOBAO(付款以前，卖家或买家主动关闭交易)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单超时到期时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("timeout_action_time")]
        public string TimeoutActionTime { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 应付金额（商品价格 * 商品数量 + 手工调整金额 - 订单优惠金额）。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }
    }
}
