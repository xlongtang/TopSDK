using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// TakeoutThirdOrder Data Structure.
    /// </summary>
    [Serializable]
    public class TakeoutThirdOrder : TopObject
    {
        /// <summary>
        /// 送餐地址
        /// </summary>
        [XmlElement("address")]
        public string Address { get; set; }

        /// <summary>
        /// 支付宝流水号
        /// </summary>
        [XmlElement("alipay_stream_id")]
        public string AlipayStreamId { get; set; }

        /// <summary>
        /// 买家在该订单所在的店铺的历史订单数量
        /// </summary>
        [XmlElement("buyer_history_order_count")]
        public long BuyerHistoryOrderCount { get; set; }

        /// <summary>
        /// 买家的用户昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 配送费
        /// </summary>
        [XmlElement("delivery_pay")]
        public string DeliveryPay { get; set; }

        /// <summary>
        /// 距离单位为米
        /// </summary>
        [XmlElement("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// 送达时间要求_结束
        /// </summary>
        [XmlElement("end_deliverytime")]
        public string EndDeliverytime { get; set; }

        /// <summary>
        /// 距离倒计时结束的秒数
        /// </summary>
        [XmlElement("end_seconds")]
        public long EndSeconds { get; set; }

        /// <summary>
        /// 用户下单方式(PC/APP)
        /// </summary>
        [XmlElement("from")]
        public long From { get; set; }

        /// <summary>
        /// 下单餐品列表
        /// </summary>
        [XmlArray("goods_list")]
        [XmlArrayItem("order_goods")]
        public List<OrderGoods> GoodsList { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 用户下单时的备注信息
        /// </summary>
        [XmlElement("note")]
        public string Note { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [XmlElement("order_status")]
        public long OrderStatus { get; set; }

        /// <summary>
        /// 0 支付宝订单 8 货到付款
        /// </summary>
        [XmlElement("order_type")]
        public long OrderType { get; set; }

        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        [XmlElement("pay_account")]
        public string PayAccount { get; set; }

        /// <summary>
        /// 就餐人数
        /// </summary>
        [XmlElement("people_number")]
        public long PeopleNumber { get; set; }

        /// <summary>
        /// 优惠列表
        /// </summary>
        [XmlArray("promotion_list")]
        [XmlArrayItem("promotion_o")]
        public List<PromotionO> PromotionList { get; set; }

        /// <summary>
        /// 送达时间要求_起始
        /// </summary>
        [XmlElement("start_deliverytime")]
        public string StartDeliverytime { get; set; }

        /// <summary>
        /// 店铺联系电话
        /// </summary>
        [XmlElement("store_contactphone")]
        public string StoreContactphone { get; set; }

        /// <summary>
        /// 分店ID
        /// </summary>
        [XmlElement("store_id")]
        public long StoreId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 订单超时的时间
        /// </summary>
        [XmlElement("time_out_stamp")]
        public string TimeOutStamp { get; set; }

        /// <summary>
        /// 总支付金额
        /// </summary>
        [XmlElement("total_pay")]
        public string TotalPay { get; set; }

        /// <summary>
        /// 用户地址对象
        /// </summary>
        [XmlElement("user_address")]
        public UserThirdAddress UserAddress { get; set; }

        /// <summary>
        /// 买家ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
