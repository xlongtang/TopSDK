using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// PromotionO Data Structure.
    /// </summary>
    [Serializable]
    public class PromotionO : TopObject
    {
        /// <summary>
        /// 优惠金额（免运费、限时打折时为空）,单位：元
        /// </summary>
        [XmlElement("discount_fee")]
        public string DiscountFee { get; set; }

        /// <summary>
        /// 赠品的宝贝id
        /// </summary>
        [XmlElement("gift_item_id")]
        public long GiftItemId { get; set; }

        /// <summary>
        /// 满就送商品时，所送商品的名称
        /// </summary>
        [XmlElement("gift_item_name")]
        public string GiftItemName { get; set; }

        /// <summary>
        /// 满就送礼物的礼物数量
        /// </summary>
        [XmlElement("gift_item_num")]
        public long GiftItemNum { get; set; }

        /// <summary>
        /// 赠送商品的类型
        /// </summary>
        [XmlElement("gift_item_type")]
        public long GiftItemType { get; set; }

        /// <summary>
        /// 赠品的skuid
        /// </summary>
        [XmlElement("gift_sku_id")]
        public long GiftSkuId { get; set; }

        /// <summary>
        /// 就是因为这个商品ID而产生的优惠
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 交易的主订单或子订单号
        /// </summary>
        [XmlElement("order_id")]
        public long OrderId { get; set; }

        /// <summary>
        /// 优惠活动的描述
        /// </summary>
        [XmlElement("promotion_desc")]
        public string PromotionDesc { get; set; }

        /// <summary>
        /// 优惠id，(由营销工具id、优惠活动id和优惠详情id组成，结构为：营销工具id-优惠活动id_优惠详情id，如mjs-123024_211143）
        /// </summary>
        [XmlElement("promotion_id")]
        public string PromotionId { get; set; }

        /// <summary>
        /// 优惠信息的名称
        /// </summary>
        [XmlElement("promotion_name")]
        public string PromotionName { get; set; }

        /// <summary>
        /// ORDER_DISCOUNT(1, "订单优惠"),      ITEM_DISCOUNT(2, "菜品优惠"),      ALIPAY_DISCOUNT(3, "支付宝优惠"),      ITEM_LARGESS(4, "满就送菜"),      GIFT_LARGESS(5, "满就送礼物");
        /// </summary>
        [XmlElement("promotion_type")]
        public long PromotionType { get; set; }

        /// <summary>
        /// item_id的sku_id
        /// </summary>
        [XmlElement("sku_id")]
        public long SkuId { get; set; }
    }
}
