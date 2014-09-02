using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// BasicMember Data Structure.
    /// </summary>
    [Serializable]
    public class BasicMember : TopObject
    {
        /// <summary>
        /// 最后一次交易的订单号
        /// </summary>
        [XmlElement("biz_order_id")]
        public long BizOrderId { get; set; }

        /// <summary>
        /// 买家会员ID
        /// </summary>
        [XmlElement("buyer_id")]
        public long BuyerId { get; set; }

        /// <summary>
        /// 会员昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 交易关闭金额
        /// </summary>
        [XmlElement("close_trade_amount")]
        public string CloseTradeAmount { get; set; }

        /// <summary>
        /// 交易关闭的笔数
        /// </summary>
        [XmlElement("close_trade_count")]
        public long CloseTradeCount { get; set; }

        /// <summary>
        /// 会员等级，0：店铺客户，1：普通会员，2：高级会员，3：VIP会员， 4：至尊VIP会员
        /// </summary>
        [XmlElement("grade")]
        public long Grade { get; set; }

        /// <summary>
        /// 分组的id集合字符串
        /// </summary>
        [XmlElement("group_ids")]
        public string GroupIds { get; set; }

        /// <summary>
        /// 购买的宝贝件数
        /// </summary>
        [XmlElement("item_num")]
        public long ItemNum { get; set; }

        /// <summary>
        /// 最后交易的日期
        /// </summary>
        [XmlElement("last_trade_time")]
        public string LastTradeTime { get; set; }

        /// <summary>
        /// 关系来源，1交易成功，2未交易成功 ,3 卖家主动吸纳
        /// </summary>
        [XmlElement("relation_source")]
        public long RelationSource { get; set; }

        /// <summary>
        /// 显示会员的状态，normal正常，delete被买家删除，blacklist黑名单
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 交易的金额
        /// </summary>
        [XmlElement("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 交易成功的次数
        /// </summary>
        [XmlElement("trade_count")]
        public long TradeCount { get; set; }
    }
}
