using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TbkShop Data Structure.
    /// </summary>
    [Serializable]
    public class TbkShop : TopObject
    {
        /// <summary>
        /// 店铺推广URL
        /// </summary>
        [XmlElement("click_url")]
        public string ClickUrl { get; set; }

        /// <summary>
        /// 店铺logo
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

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
        /// 店铺地址
        /// </summary>
        [XmlElement("shop_url")]
        public string ShopUrl { get; set; }

        /// <summary>
        /// 店铺用户id
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
