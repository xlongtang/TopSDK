using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Promotion Data Structure.
    /// </summary>
    [Serializable]
    public class Promotion : TopObject
    {
        /// <summary>
        /// 减价件数，1只减一件，0表示多件
        /// </summary>
        [XmlElement("decrease_num")]
        public long DecreaseNum { get; set; }

        /// <summary>
        /// 优惠类型，PRICE表示按价格优惠，DISCOUNT表示按折扣优惠
        /// </summary>
        [XmlElement("discount_type")]
        public string DiscountType { get; set; }

        /// <summary>
        /// 优惠额度
        /// </summary>
        [XmlElement("discount_value")]
        public string DiscountValue { get; set; }

        /// <summary>
        /// 优惠结束日期
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 商品数字ID
        /// </summary>
        [XmlElement("num_iid")]
        public long NumIid { get; set; }

        /// <summary>
        /// 优惠描述
        /// </summary>
        [XmlElement("promotion_desc")]
        public string PromotionDesc { get; set; }

        /// <summary>
        /// 优惠ID
        /// </summary>
        [XmlElement("promotion_id")]
        public long PromotionId { get; set; }

        /// <summary>
        /// 优惠标题，显示在宝贝详情页面的优惠图标的tip。
        /// </summary>
        [XmlElement("promotion_title")]
        public string PromotionTitle { get; set; }

        /// <summary>
        /// 优惠开始日期
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 优惠策略状态，ACTIVE表示有效，UNACTIVE表示无效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 对应的人群标签ID
        /// </summary>
        [XmlElement("tag_id")]
        public long TagId { get; set; }
    }
}
