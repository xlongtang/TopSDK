using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaobaokeShop Data Structure.
    /// </summary>
    [Serializable]
    public class TaobaokeShop : TopObject
    {
        /// <summary>
        /// 店铺内商品总数
        /// </summary>
        [XmlElement("auction_count")]
        public long AuctionCount { get; set; }

        /// <summary>
        /// 店铺推广URL
        /// </summary>
        [XmlElement("click_url")]
        public string ClickUrl { get; set; }

        /// <summary>
        /// 淘宝客店铺佣金比率
        /// </summary>
        [XmlElement("commission_rate")]
        public string CommissionRate { get; set; }

        /// <summary>
        /// 店铺掌柜信用等级
        /// </summary>
        [XmlElement("seller_credit")]
        public string SellerCredit { get; set; }

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
        /// 店铺类型 B=商城卖家 C=普通卖家
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 累计推广量
        /// </summary>
        [XmlElement("total_auction")]
        public string TotalAuction { get; set; }

        /// <summary>
        /// 店铺用户id
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
