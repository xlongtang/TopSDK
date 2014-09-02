using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// HotelOrder Data Structure.
    /// </summary>
    [Serializable]
    public class HotelOrder : TopObject
    {
        /// <summary>
        /// 支付宝交易号，22位字符
        /// </summary>
        [XmlElement("alipay_trade_no")]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 买家最早到达时间
        /// </summary>
        [XmlElement("arrive_early")]
        public string ArriveEarly { get; set; }

        /// <summary>
        /// 买家最晚到达时间
        /// </summary>
        [XmlElement("arrive_late")]
        public string ArriveLate { get; set; }

        /// <summary>
        /// 买家淘宝账号
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 入住时间
        /// </summary>
        [XmlElement("checkin_date")]
        public string CheckinDate { get; set; }

        /// <summary>
        /// 离店时间
        /// </summary>
        [XmlElement("checkout_date")]
        public string CheckoutDate { get; set; }

        /// <summary>
        /// 备注，存储关于礼品的信息，比如杜蕾斯
        /// </summary>
        [XmlElement("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// 联系人姓名
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系人电话
        /// </summary>
        [XmlElement("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 备用联系人电话
        /// </summary>
        [XmlElement("contact_phone_bak")]
        public string ContactPhoneBak { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商品id
        /// </summary>
        [XmlElement("gid")]
        public long Gid { get; set; }

        /// <summary>
        /// 入住人信息
        /// </summary>
        [XmlArray("guests")]
        [XmlArrayItem("order_guest")]
        public List<OrderGuest> Guests { get; set; }

        /// <summary>
        /// 酒店id
        /// </summary>
        [XmlElement("hid")]
        public long Hid { get; set; }

        /// <summary>
        /// 物流状态。STATUS_UNCONSIGNED：未发货 -> 等待卖家发货。STATUS_CONSIGNED：已发货 -> 等待买家确认收货。STATUS_DELIVERED：已收货 -> 交易成功。STATUS_REVERT：已经退货 -> 交易失败。STATUS_DELIVERED_PART：部分发货 -> 交易成功。STATUS_NO_OUT_ORDER：还未创建物流订单
        /// </summary>
        [XmlElement("logistics_status")]
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// 买家留言
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 订单修改时间
        /// </summary>
        [XmlElement("modified")]
        public string Modified { get; set; }

        /// <summary>
        /// 天数
        /// </summary>
        [XmlElement("nights")]
        public long Nights { get; set; }

        /// <summary>
        /// 酒店订单id
        /// </summary>
        [XmlElement("oid")]
        public long Oid { get; set; }

        /// <summary>
        /// 合作方订单号,最长250个字符
        /// </summary>
        [XmlElement("out_oid")]
        public string OutOid { get; set; }

        /// <summary>
        /// 付款时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 实付款（分）
        /// </summary>
        [XmlElement("payment")]
        public long Payment { get; set; }

        /// <summary>
        /// 下单时每间夜的价格（分）
        /// </summary>
        [XmlArray("prices")]
        [XmlArrayItem("number")]
        public List<long> Prices { get; set; }

        /// <summary>
        /// 退款状态。STATUS_WAIT_SELLER_AGREE：买家已经申请退款，等待卖家同意。STATUS_WAIT_BUYER_RETURN_GOODS：卖家已经同意退款，等待买家退货。STATUS_WAIT_SELLER_CONFIRM_GOODS：买家已经退货，等待卖家确认收货。STATUS_CLOSED：退款关闭。STATUS_SUCCESS：退款成功->买家取消预定。STATUS_SELLER_REFUSE_BUYER：卖家拒绝退款。STATUS_WAIT_OUT_PAY_SYSTEM_REFUND：等待外部交易系统退款。STATUS_NO_REFUND：没有申请退款。STATUS_ACTIVE_REFUND：有活动退款。STATUS_END_REFUND：退款结束。
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 房型id
        /// </summary>
        [XmlElement("rid")]
        public long Rid { get; set; }

        /// <summary>
        /// 房间数
        /// </summary>
        [XmlElement("room_number")]
        public long RoomNumber { get; set; }

        /// <summary>
        /// 卖家淘宝账号
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 淘宝订单id
        /// </summary>
        [XmlElement("tid")]
        public long Tid { get; set; }

        /// <summary>
        /// 总房价（分）
        /// </summary>
        [XmlElement("total_room_price")]
        public long TotalRoomPrice { get; set; }

        /// <summary>
        /// 交易状态。WAIT_BUYER_PAY：未冻结/未付款 -> 等待买家付款。WAIT_SELLER_SEND_GOODS：已冻结/已付款 -> 等待卖家发货 -> 等待卖家确认。TRADE_CLOSED：已退款 -> 交易关闭。TRADE_FINISHED：已转交易 -> 交易成功。TRADE_NO_CREATE_PAY：没有创建支付宝交易。TRADE_CLOSED_BY_TAOBAO：交易被淘宝关闭->卖家关闭交易或卖家核实未入住。TRADE_SUCCESS：预定成功（等待卖家核实入住）
        /// </summary>
        [XmlElement("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 支付类型。A：全额支付。B：灵活支付－手续费。C：灵活支付－订金。D：灵活支付－手续费/间夜
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
