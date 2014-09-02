using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// LimitDiscountDetail Data Structure.
    /// </summary>
    [Serializable]
    public class LimitDiscountDetail : TopObject
    {
        /// <summary>
        /// 限时打折结束时间。
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 该商品限时折扣
        /// </summary>
        [XmlElement("item_discount")]
        public string ItemDiscount { get; set; }

        /// <summary>
        /// 商品的id(数字类型)
        /// </summary>
        [XmlElement("item_id")]
        public long ItemId { get; set; }

        /// <summary>
        /// 限时打折名称
        /// </summary>
        [XmlElement("limit_discount_name")]
        public string LimitDiscountName { get; set; }

        /// <summary>
        /// 每人限购数量，1、2、5、10000(不限)。
        /// </summary>
        [XmlElement("limit_num")]
        public long LimitNum { get; set; }

        /// <summary>
        /// 限时打折开始时间。
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
