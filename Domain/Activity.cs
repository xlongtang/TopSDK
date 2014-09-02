using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// Activity Data Structure.
    /// </summary>
    [Serializable]
    public class Activity : TopObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 领用优惠券的链接
        /// </summary>
        [XmlElement("activity_url")]
        public string ActivityUrl { get; set; }

        /// <summary>
        /// 已经领取的优惠券的数量
        /// </summary>
        [XmlElement("applied_count")]
        public long AppliedCount { get; set; }

        /// <summary>
        /// 活动对应的优惠券ID
        /// </summary>
        [XmlElement("coupon_id")]
        public long CouponId { get; set; }

        /// <summary>
        /// self代表自己创建，other他人创建
        /// </summary>
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 每个买家限领取优惠券的数量，1～5张
        /// </summary>
        [XmlElement("person_limit_count")]
        public long PersonLimitCount { get; set; }

        /// <summary>
        /// enabled代表有效，invalid代表失效。other代表空值
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 卖家设置优惠券领取的总领用量
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
