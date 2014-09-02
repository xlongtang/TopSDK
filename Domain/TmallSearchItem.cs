using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TmallSearchItem Data Structure.
    /// </summary>
    [Serializable]
    public class TmallSearchItem : TopObject
    {
        /// <summary>
        /// 邮费
        /// </summary>
        [XmlElement("fast_post_fee")]
        public string FastPostFee { get; set; }

        /// <summary>
        /// 是否货到付款
        /// </summary>
        [XmlElement("is_cod")]
        public long IsCod { get; set; }

        /// <summary>
        /// 是否折扣
        /// </summary>
        [XmlElement("is_promotion")]
        public bool IsPromotion { get; set; }

        /// <summary>
        /// 搜索宝贝的数字id
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 搜索宝贝的宝贝所在地
        /// </summary>
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 搜索宝贝的卖家昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 搜索宝贝的图片url
        /// </summary>
        [XmlElement("pic_path")]
        public string PicPath { get; set; }

        /// <summary>
        /// 搜索宝贝的一口价
        /// </summary>
        [XmlElement("price")]
        public string Price { get; set; }

        /// <summary>
        /// 搜索宝贝的一口价折扣价
        /// </summary>
        [XmlElement("price_with_rate")]
        public string PriceWithRate { get; set; }

        /// <summary>
        /// 搜索宝贝的卖家所在地
        /// </summary>
        [XmlElement("seller_loc")]
        public string SellerLoc { get; set; }

        /// <summary>
        /// 是否免邮
        /// </summary>
        [XmlElement("shipping")]
        public long Shipping { get; set; }

        /// <summary>
        /// 搜索宝贝的已售数量
        /// </summary>
        [XmlElement("sold")]
        public string Sold { get; set; }

        /// <summary>
        /// 搜索宝贝的spuid
        /// </summary>
        [XmlElement("spu_id")]
        public long SpuId { get; set; }

        /// <summary>
        /// 搜索宝贝的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 搜索宝贝url
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 搜索宝贝的卖家数字id
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
