using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// ItemPromotion Data Structure.
    /// </summary>
    [Serializable]
    public class ItemPromotion : TopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 减多少钱。当is_decrease_money为true时，该值才有意义。注意：该值单位为分，即100表示1元。
        /// </summary>
        [XmlElement("decrease_amount")]
        public long DecreaseAmount { get; set; }

        /// <summary>
        /// 活动的有效条件、人群和行为描述。
        /// </summary>
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 折扣值。当is_discount为true时，该值才有意义。注意：800表示8折。
        /// </summary>
        [XmlElement("discount_rate")]
        public long DiscountRate { get; set; }

        /// <summary>
        /// 活动结束时间。
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 是否有减钱行为。
        /// </summary>
        [XmlElement("is_decrease_money")]
        public bool IsDecreaseMoney { get; set; }

        /// <summary>
        /// 是否有打折行为。
        /// </summary>
        [XmlElement("is_discount")]
        public bool IsDiscount { get; set; }

        /// <summary>
        /// 是否指定用户标签。
        /// </summary>
        [XmlElement("is_user_tag")]
        public bool IsUserTag { get; set; }

        /// <summary>
        /// 活动名称。
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 活动范围：0表示全部参与； 1表示部分商品参与。
        /// </summary>
        [XmlElement("participate_range")]
        public long ParticipateRange { get; set; }

        /// <summary>
        /// 活动开始时间。
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 用户标签。当is_user_tag为true时，该值才有意义。
        /// </summary>
        [XmlElement("user_tag")]
        public string UserTag { get; set; }
    }
}
