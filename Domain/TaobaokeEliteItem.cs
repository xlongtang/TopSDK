using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaobaokeEliteItem Data Structure.
    /// </summary>
    [Serializable]
    public class TaobaokeEliteItem : TopObject
    {
        /// <summary>
        /// 商品折扣价
        /// </summary>
        [XmlElement("discount_price")]
        public string DiscountPrice { get; set; }

        /// <summary>
        /// 宝贝折扣率。8000代表80.00%
        /// </summary>
        [XmlElement("discount_rate")]
        public long DiscountRate { get; set; }

        /// <summary>
        /// 是否消费者保障。true：参与消费者保障
        /// </summary>
        [XmlElement("is_cust_assurance")]
        public bool IsCustAssurance { get; set; }

        /// <summary>
        /// 是否7天退换货。true：参与7天退换货
        /// </summary>
        [XmlElement("is_exchange7")]
        public bool IsExchange7 { get; set; }

        /// <summary>
        /// 是否正品保障。true：参与正品保障
        /// </summary>
        [XmlElement("is_item_assurance")]
        public bool IsItemAssurance { get; set; }

        /// <summary>
        /// 是否24小时发货。true：参与24小时发货
        /// </summary>
        [XmlElement("is_post24")]
        public bool IsPost24 { get; set; }

        /// <summary>
        /// 是否免邮。true：参与免邮
        /// </summary>
        [XmlElement("is_postage_free")]
        public bool IsPostageFree { get; set; }

        /// <summary>
        /// 宝贝推广点击串url
        /// </summary>
        [XmlElement("item_click_url")]
        public string ItemClickUrl { get; set; }

        /// <summary>
        /// 商品所在地
        /// </summary>
        [XmlElement("item_location")]
        public string ItemLocation { get; set; }

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
        /// 邮费
        /// </summary>
        [XmlElement("post_fee")]
        public string PostFee { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 卖家信用等级
        /// </summary>
        [XmlElement("seller_credit")]
        public long SellerCredit { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 商品所在店铺的推广点击url
        /// </summary>
        [XmlElement("shop_click_url")]
        public string ShopClickUrl { get; set; }

        /// <summary>
        /// 店铺类型:B(商城),C(集市)
        /// </summary>
        [XmlElement("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 30天成交量
        /// </summary>
        [XmlElement("thirtyday_sales")]
        public long ThirtydaySales { get; set; }

        /// <summary>
        /// 商品title 宝贝名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
