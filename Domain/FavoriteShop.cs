using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// FavoriteShop Data Structure.
    /// </summary>
    [Serializable]
    public class FavoriteShop : TopObject
    {
        /// <summary>
        /// 店铺卖家信用
        /// </summary>
        [XmlElement("rate")]
        public long Rate { get; set; }

        /// <summary>
        /// 卖家ID
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public long ShopId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺LOGO图片
        /// </summary>
        [XmlElement("shop_pic")]
        public string ShopPic { get; set; }

        /// <summary>
        /// 店铺首页链接
        /// </summary>
        [XmlElement("shop_url")]
        public string ShopUrl { get; set; }
    }
}
