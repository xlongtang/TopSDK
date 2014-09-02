using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// SpItemInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SpItemInfo : TopObject
    {
        /// <summary>
        /// 商品优惠价格, 如果为空则无优惠.精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("final_price")]
        public string FinalPrice { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品的URL
        /// </summary>
        [XmlElement("item_url")]
        public string ItemUrl { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 商品价格.精确到2位小数;单位:元。如:200.07，表示:200元7分
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 卖家数字ID
        /// </summary>
        [XmlElement("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 店铺的链接URL
        /// </summary>
        [XmlElement("shop_url")]
        public string ShopUrl { get; set; }

        /// <summary>
        /// 商品标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 是否是淘客商品（0-非淘客商品，5-淘客商品）
        /// </summary>
        [XmlElement("tk")]
        public string Tk { get; set; }

        /// <summary>
        /// 是否天猫： 1是，0否
        /// </summary>
        [XmlElement("tmall")]
        public string Tmall { get; set; }
    }
}
