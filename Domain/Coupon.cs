using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Coupon Data Structure.
    /// </summary>
    [Serializable]
    public class Coupon : TopObject
    {
        /// <summary>
        /// 订单满多少分才能用这个优惠券，501就是满501分能使用。注意：返回的是“分”，不是“元”
        /// </summary>
        [XmlElement("condition")]
        public long Condition { get; set; }

        /// <summary>
        /// 优惠券ID
        /// </summary>
        [XmlElement("coupon_id")]
        public long CouponId { get; set; }

        /// <summary>
        /// 优惠券创建时间
        /// </summary>
        [XmlElement("creat_time")]
        public string CreatTime { get; set; }

        /// <summary>
        /// 优惠券的创建渠道，自己创建/他人创建
        /// </summary>
        [XmlElement("create_channel")]
        public string CreateChannel { get; set; }

        /// <summary>
        /// 优惠券的面值，返回的是“分”，不是“元”，500代表500分相当于5元
        /// </summary>
        [XmlElement("denominations")]
        public long Denominations { get; set; }

        /// <summary>
        /// 优惠券的截止日期
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }
    }
}
