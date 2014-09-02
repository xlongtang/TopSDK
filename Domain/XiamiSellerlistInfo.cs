using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// XiamiSellerlistInfo Data Structure.
    /// </summary>
    [Serializable]
    public class XiamiSellerlistInfo : TopObject
    {
        /// <summary>
        /// 来源
        /// </summary>
        [XmlElement("comefrom")]
        public string Comefrom { get; set; }

        /// <summary>
        /// 礼包订单ID
        /// </summary>
        [XmlElement("gift_order_id")]
        public long GiftOrderId { get; set; }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        [XmlElement("gmt_create")]
        public long GmtCreate { get; set; }

        /// <summary>
        /// 领取时间戳
        /// </summary>
        [XmlElement("gmt_get")]
        public long GmtGet { get; set; }

        /// <summary>
        /// 后付款订单付款时间
        /// </summary>
        [XmlElement("gmt_pay")]
        public long GmtPay { get; set; }

        /// <summary>
        /// 数字ID
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// 是否已领取
        /// </summary>
        [XmlElement("is_get")]
        public long IsGet { get; set; }

        /// <summary>
        /// 是否付款
        /// </summary>
        [XmlElement("is_pay")]
        public long IsPay { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [XmlElement("original_order_id")]
        public long OriginalOrderId { get; set; }

        /// <summary>
        /// 礼包名称
        /// </summary>
        [XmlElement("packname")]
        public string Packname { get; set; }

        /// <summary>
        /// 礼包价格
        /// </summary>
        [XmlElement("pay")]
        public long Pay { get; set; }

        /// <summary>
        /// 关联ID
        /// </summary>
        [XmlElement("relation_id")]
        public long RelationId { get; set; }

        /// <summary>
        /// 卖家ID
        /// </summary>
        [XmlElement("seller_id")]
        public long SellerId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [XmlElement("shop_id")]
        public long ShopId { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 店铺URL
        /// </summary>
        [XmlElement("shop_url")]
        public string ShopUrl { get; set; }

        /// <summary>
        /// 买家ID
        /// </summary>
        [XmlElement("taobao_uid")]
        public long TaobaoUid { get; set; }

        /// <summary>
        /// 礼包类型
        /// </summary>
        [XmlElement("type")]
        public long Type { get; set; }

        /// <summary>
        /// 领取的虾米ID
        /// </summary>
        [XmlElement("user_id")]
        public long UserId { get; set; }
    }
}
