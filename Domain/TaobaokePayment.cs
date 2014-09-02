using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaobaokePayment Data Structure.
    /// </summary>
    [Serializable]
    public class TaobaokePayment : TopObject
    {
        /// <summary>
        /// 应用授权码
        /// </summary>
        [XmlElement("app_key")]
        public string AppKey { get; set; }

        /// <summary>
        /// 所购买商品的类目ID
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 所购买商品的类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 用户获得的佣金
        /// </summary>
        [XmlElement("commission")]
        public string Commission { get; set; }

        /// <summary>
        /// 佣金比率。比如：0.01代表1%
        /// </summary>
        [XmlElement("commission_rate")]
        public string CommissionRate { get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [XmlElement("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 商品成交数量
        /// </summary>
        [XmlElement("item_num")]
        public long ItemNum { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("item_title")]
        public string ItemTitle { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("num_iid")]
        public long NumIid { get; set; }

        /// <summary>
        /// 推广渠道
        /// </summary>
        [XmlElement("outer_code")]
        public string OuterCode { get; set; }

        /// <summary>
        /// 成交价格
        /// </summary>
        [XmlElement("pay_price")]
        public string PayPrice { get; set; }

        /// <summary>
        /// 成交时间
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 实际支付金额
        /// </summary>
        [XmlElement("real_pay_fee")]
        public string RealPayFee { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_title")]
        public string ShopTitle { get; set; }

        /// <summary>
        /// 淘宝交易号
        /// </summary>
        [XmlElement("trade_id")]
        public long TradeId { get; set; }

        /// <summary>
        /// 淘宝父交易号
        /// </summary>
        [XmlElement("trade_parent_id")]
        public long TradeParentId { get; set; }
    }
}
