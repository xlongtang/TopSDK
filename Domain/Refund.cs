using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Refund Data Structure.
    /// </summary>
    [Serializable]
    public class Refund : TopObject
    {
        /// <summary>
        /// 卖家收货地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 退款先行垫付默认的未申请状态 0;  退款先行垫付申请中  1;  退款先行垫付，垫付完成 2;  退款先行垫付，卖家拒绝收货 3;  退款先行垫付，垫付关闭 4;  退款先行垫付，垫付分账成功 5;
        /// </summary>
        [XmlElement("advance_status")]
        public long AdvanceStatus { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("alipay_no")]
        public string AlipayNo { get; set; }

        /// <summary>
        /// 买家昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 退款申请时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 不需客服介入1;  需要客服介入2;  客服已经介入3;  客服初审完成 4;  客服主管复审失败5;  客服处理完成6;
        /// </summary>
        [XmlElement("cs_status")]
        public long CsStatus { get; set; }

        /// <summary>
        /// 退款说明
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 退货时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("good_return_time")]
        public string GoodReturnTime { get; set; }

        /// <summary>
        /// 货物状态。可选值  BUYER_NOT_RECEIVED (买家未收到货)   BUYER_RECEIVED (买家已收到货)   BUYER_RETURNED_GOODS (买家已退货)
        /// </summary>
        [XmlElement("good_status")]
        public string GoodStatus { get; set; }

        /// <summary>
        /// 买家是否需要退货。可选值:true(是),false(否)
        /// </summary>
        [XmlElement("has_good_return")]
        public bool HasGoodReturn { get; set; }

        /// <summary>
        /// 申请退款的商品字符串编号(注意：iid近期即将废弃，请用num_iid参数)
        /// </summary>
        [XmlElement("iid")]
        public string Iid { get; set; }

        /// <summary>
        /// 更新时间。格式:yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 商品购买数量
        /// </summary>
        [XmlElement("num")]
        public long Num { get; set; }

        /// <summary>
        /// 申请退款的商品数字编号
        /// </summary>
        [XmlElement("num_iid")]
        public long NumIid { get; set; }

        /// <summary>
        /// 子订单号。如果是单笔交易oid会等于tid
        /// </summary>
        [XmlElement("oid")]
        public long Oid { get; set; }

        /// <summary>
        /// 退款对应的订单交易状态。  可选值  TRADE_NO_CREATE_PAY(没有创建支付宝交易)   WAIT_BUYER_PAY(等待买家付款)   WAIT_SELLER_SEND_GOODS(等待卖家发货,即:买家已付款)   WAIT_BUYER_CONFIRM_GOODS(等待买家确认收货,即:卖家已发货)   TRADE_BUYER_SIGNED(买家已签收,货到付款专用)   TRADE_FINISHED(交易成功)   TRADE_CLOSED(交易关闭)   TRADE_CLOSED_BY_TAOBAO(交易被淘宝关闭)   ALL_WAIT_PAY(包含：WAIT_BUYER_PAY、TRADE_NO_CREATE_PAY)   ALL_CLOSED(包含：TRADE_CLOSED、TRADE_CLOSED_BY_TAOBAO)   取自"http://open.taobao.com/dev/index.php/%E4%BA%A4%E6%98%93%E7%8A%B6%E6%80%81"
        /// </summary>
        [XmlElement("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 支付给卖家的金额(交易总金额-退还给买家的金额)。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("payment")]
        public string Payment { get; set; }

        /// <summary>
        /// 商品价格。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 退还金额(退还给买家的金额)。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 退款单号
        /// </summary>
        [XmlElement("refund_id")]
        public long RefundId { get; set; }

        /// <summary>
        /// 退款超时结构RefundRemindTimeout
        /// </summary>
        [XmlElement("refund_remind_timeout")]
        public RefundRemindTimeout RefundRemindTimeout { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 物流方式.可选值:free(卖家包邮),post(平邮),express(快递),ems(EMS).
        /// </summary>
        [XmlElement("shipping_type")]
        public string ShippingType { get; set; }

        /// <summary>
        /// 退货运单号
        /// </summary>
        [XmlElement("sid")]
        public string Sid { get; set; }

        /// <summary>
        /// 分账给卖家的钱
        /// </summary>
        [XmlElement("split_seller_fee")]
        public string SplitSellerFee { get; set; }

        /// <summary>
        /// 分账给淘宝的钱
        /// </summary>
        [XmlElement("split_taobao_fee")]
        public string SplitTaobaoFee { get; set; }

        /// <summary>
        /// 退款状态。  可选值  WAIT_SELLER_AGREE(买家已经申请退款，等待卖家同意)   WAIT_BUYER_RETURN_GOODS(卖家已经同意退款，等待买家退货)   WAIT_SELLER_CONFIRM_GOODS(买家已经退货，等待卖家确认收货)   SELLER_REFUSE_BUYER(卖家拒绝退款)   CLOSED(退款关闭)   SUCCESS(退款成功)
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 淘宝交易单号
        /// </summary>
        [XmlElement("tid")]
        public long Tid { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 交易总金额。精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("total_fee")]
        public string TotalFee { get; set; }
    }
}
