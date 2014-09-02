using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TbkItem Data Structure.
    /// </summary>
    [Serializable]
    public class TbkItem : TopObject
    {
        /// <summary>
        /// 推广点击url
        /// </summary>
        [XmlElement("click_url")]
        public string ClickUrl { get; set; }

        /// <summary>
        /// 商品url
        /// </summary>
        [XmlElement("item_url")]
        public string ItemUrl { get; set; }

        /// <summary>
        /// 卖家昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 淘宝客商品数字id
        /// </summary>
        [XmlElement("num_iid")]
        public long NumIid { get; set; }

        /// <summary>
        /// 图片url
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 店铺url
        /// </summary>
        [XmlElement("shop_url")]
        public string ShopUrl { get; set; }

        /// <summary>
        /// 商品title 宝贝名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 30天内交易量
        /// </summary>
        [XmlElement("volume")]
        public long Volume { get; set; }
    }
}
