using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// CouponDetail Data Structure.
    /// </summary>
    [Serializable]
    public class CouponDetail : TopObject
    {
        /// <summary>
        /// 买家的昵称
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 优惠券的发放渠道：渠道有rewardforgifts：满就送，marketingMessage：营销消息，activityofget：活动领取，createActivity：创建活动，ISV
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 目前优惠券编号
        /// </summary>
        [XmlElement("coupon_number")]
        public long CouponNumber { get; set; }

        /// <summary>
        /// 优惠券使用情况Unused：未使用using：使用中used：已使用
        /// </summary>
        [XmlElement("state")]
        public string State { get; set; }
    }
}
