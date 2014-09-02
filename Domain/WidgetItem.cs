using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// WidgetItem Data Structure.
    /// </summary>
    [Serializable]
    public class WidgetItem : TopObject
    {
        /// <summary>
        /// 该商品能否加入购物车
        /// </summary>
        [XmlElement("add_to_cart")]
        public bool AddToCart { get; set; }

        /// <summary>
        /// 商品的状态。onsale出售中，instock仓库中
        /// </summary>
        [XmlElement("approve_status")]
        public string ApproveStatus { get; set; }

        /// <summary>
        /// 商品的点击链接，如果此商品有淘宝客会根据app所属的淘宝用户进行淘宝客连接转换，如果无淘宝客此字段为淘宝商品详情地址
        /// </summary>
        [XmlElement("click_url")]
        public string ClickUrl { get; set; }

        /// <summary>
        /// 是否商城的商品
        /// </summary>
        [XmlElement("is_mall")]
        public bool IsMall { get; set; }

        /// <summary>
        /// 淘宝商品的数字id，与Item的num_iid一致
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 商品图片列表，对应Item的itemImgs
        /// </summary>
        [XmlArray("item_pics")]
        [XmlArrayItem("string")]
        public List<string> ItemPics { get; set; }

        /// <summary>
        /// 商品关联的商品优惠信息
        /// </summary>
        [XmlArray("item_promotion_data")]
        [XmlArrayItem("promotion_in_item")]
        public List<PromotionInItem> ItemPromotionData { get; set; }

        /// <summary>
        /// 商品的主图地址，对应Item的pic_url
        /// </summary>
        [XmlElement("pic_url")]
        public string PicUrl { get; set; }

        /// <summary>
        /// 淘宝商品的价格，对应Item的price。如果商品为无sku或者所有sku价格一致的商品，此字段为价格（199.99）；如果商品有多sku且有一个价格区间，次字段为商品的价格区间，中间用‘-’连接
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 商品的数量，对应Item的num
        /// </summary>
        [XmlElement("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 商品卖家昵称，对应Item的nick
        /// </summary>
        [XmlElement("seller_nick")]
        public string SellerNick { get; set; }

        /// <summary>
        /// 商品关联的卖家店铺优惠信息
        /// </summary>
        [XmlArray("shop_promotion_data")]
        [XmlArrayItem("promotion_in_shop")]
        public List<PromotionInShop> ShopPromotionData { get; set; }

        /// <summary>
        /// 商品关联sku对应的商品属性列表信息
        /// </summary>
        [XmlArray("sku_props")]
        [XmlArrayItem("widget_sku_props")]
        public List<WidgetSkuProps> SkuProps { get; set; }

        /// <summary>
        /// 商品关联的sku列表信息
        /// </summary>
        [XmlArray("skus")]
        [XmlArrayItem("widget_sku")]
        public List<WidgetSku> Skus { get; set; }

        /// <summary>
        /// 淘宝商品的标题，与Item的title一致
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
