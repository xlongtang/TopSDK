using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// LimitDiscount Data Structure.
    /// </summary>
    [Serializable]
    public class LimitDiscount : TopObject
    {
        /// <summary>
        /// 限时打折结束时间。
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 该限时打折宝贝数量。
        /// </summary>
        [XmlElement("item_num")]
        public long ItemNum { get; set; }

        /// <summary>
        /// 限时打折ID。
        /// </summary>
        [XmlElement("limit_discount_id")]
        public long LimitDiscountId { get; set; }

        /// <summary>
        /// 限时打折名称。
        /// </summary>
        [XmlElement("limit_discount_name")]
        public string LimitDiscountName { get; set; }

        /// <summary>
        /// 限时打折开始时间。
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
