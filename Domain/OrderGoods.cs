using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// OrderGoods Data Structure.
    /// </summary>
    [Serializable]
    public class OrderGoods : TopObject
    {
        /// <summary>
        /// 商品的商家编码
        /// </summary>
        [XmlElement("auction_code")]
        public string AuctionCode { get; set; }

        /// <summary>
        /// 外卖商品购买数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 外卖商品外部ID
        /// </summary>
        [XmlElement("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商品图片id
        /// </summary>
        [XmlElement("goods_pic_id")]
        public string GoodsPicId { get; set; }

        /// <summary>
        /// 物流订单商品数量
        /// </summary>
        [XmlElement("goods_quantity")]
        public long GoodsQuantity { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 是否是优惠商品
        /// </summary>
        [XmlElement("is_promotion")]
        public bool IsPromotion { get; set; }

        /// <summary>
        /// 商品价格
        /// </summary>
        [XmlElement("item_value")]
        public long ItemValue { get; set; }

        /// <summary>
        /// 外卖商品名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 商品的唯一编码
        /// </summary>
        [XmlElement("order_goods_id")]
        public long OrderGoodsId { get; set; }

        /// <summary>
        /// 0 未优惠 1 已优惠
        /// </summary>
        [XmlElement("promotion_status")]
        public long PromotionStatus { get; set; }

        /// <summary>
        /// 外卖商品实际购买价格
        /// </summary>
        [XmlElement("real_price")]
        public string RealPrice { get; set; }

        /// <summary>
        /// 销售属性
        /// </summary>
        [XmlElement("sell_property")]
        public string SellProperty { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
