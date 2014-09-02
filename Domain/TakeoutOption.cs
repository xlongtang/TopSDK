using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// TakeoutOption Data Structure.
    /// </summary>
    [Serializable]
    public class TakeoutOption : TopObject
    {
        /// <summary>
        /// 配送范围地图坐标
        /// </summary>
        [XmlElement("area_range")]
        public string AreaRange { get; set; }

        /// <summary>
        /// 支持货到付款:1，不支持货到付款：0
        /// </summary>
        [XmlElement("cash_on_delivery")]
        public long CashOnDelivery { get; set; }

        /// <summary>
        /// 主营类目id
        /// </summary>
        [XmlElement("cateid")]
        public long Cateid { get; set; }

        /// <summary>
        /// 配送费
        /// </summary>
        [XmlElement("delivery_amount")]
        public string DeliveryAmount { get; set; }

        /// <summary>
        /// 配送时间
        /// </summary>
        [XmlElement("delivery_time")]
        public string DeliveryTime { get; set; }

        /// <summary>
        /// 配送预留时间
        /// </summary>
        [XmlElement("early_minutes")]
        public long EarlyMinutes { get; set; }

        /// <summary>
        /// 满多少免运费
        /// </summary>
        [XmlElement("full_amount")]
        public string FullAmount { get; set; }

        /// <summary>
        /// 起送金额
        /// </summary>
        [XmlElement("minimum_amount")]
        public string MinimumAmount { get; set; }

        /// <summary>
        /// 外卖店手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 外卖店铺名称
        /// </summary>
        [XmlElement("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 外卖店铺id
        /// </summary>
        [XmlElement("shopid")]
        public long Shopid { get; set; }

        /// <summary>
        /// 预定，当天：1，三天内：3，七天内：7
        /// </summary>
        [XmlElement("support_days")]
        public long SupportDays { get; set; }
    }
}
