using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TaobaokeItem Data Structure.
    /// </summary>
    [Serializable]
    public class TaobaokeItem : TopObject
    {
        /// <summary>
        /// 推广点击url
        /// </summary>
        [XmlElement("click_url")]
        public string ClickUrl { get; set; }

        /// <summary>
        /// 淘宝客佣金
        /// </summary>
        [XmlElement("commission")]
        public string Commission { get; set; }

        /// <summary>
        /// 累计成交量.注：返回的数据是30天内累计推广量
        /// </summary>
        [XmlElement("commission_num")]
        public string CommissionNum { get; set; }

        /// <summary>
        /// 淘宝客佣金比率，比如：1234.00代表12.34%
        /// </summary>
        [XmlElement("commission_rate")]
        public string CommissionRate { get; set; }

        /// <summary>
        /// 累计总支出佣金量
        /// </summary>
        [XmlElement("commission_volume")]
        public string CommissionVolume { get; set; }

        /// <summary>
        /// 折扣活动结束时间
        /// </summary>
        [XmlElement("coupon_end_time")]
        public string CouponEndTime { get; set; }

        /// <summary>
        /// 折扣价格
        /// </summary>
        [XmlElement("coupon_price")]
        public string CouponPrice { get; set; }

        /// <summary>
        /// 折扣比率
        /// </summary>
        [XmlElement("coupon_rate")]
        public string CouponRate { get; set; }

        /// <summary>
        /// 折扣活动开始时间
        /// </summary>
        [XmlElement("coupon_start_time")]
        public string CouponStartTime { get; set; }

        /// <summary>
        /// 商品所在地
        /// </summary>
        [XmlElement("item_location")]
        public string ItemLocation { get; set; }

        /// <summary>
        /// 淘宝客关键词搜索URL
        /// </summary>
        [XmlElement("keyword_click_url")]
        public string KeywordClickUrl { get; set; }

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
        /// 促销价格
        /// </summary>
        [XmlElement("promotion_price")]
        public string PromotionPrice { get; set; }

        /// <summary>
        /// 卖家信用等级
        /// </summary>
        [XmlElement("seller_credit_score")]
        public long SellerCreditScore { get; set; }

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
        /// 淘宝客类目推广URL
        /// </summary>
        [XmlElement("taobaoke_cat_click_url")]
        public string TaobaokeCatClickUrl { get; set; }

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
