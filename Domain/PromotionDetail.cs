using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// PromotionDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PromotionDetail : TopObject
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
        public string GiftItemId { get; set; }

        /// <summary>
        /// 满就送商品时，所送商品的名称
        /// </summary>
        [XmlElement("gift_item_name")]
        public string GiftItemName { get; set; }

        /// <summary>
        /// 满就送礼物的礼物数量
        /// </summary>
        [XmlElement("gift_item_num")]
        public string GiftItemNum { get; set; }

        /// <summary>
        /// 交易的主订单或子订单号
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

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
    }
}
