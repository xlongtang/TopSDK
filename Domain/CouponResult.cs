using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// CouponResult Data Structure.
    /// </summary>
    [Serializable]
    public class CouponResult : TopObject
    {
        /// <summary>
        /// 张三
        /// </summary>
        [XmlElement("buyer_nick")]
        public string BuyerNick { get; set; }

        /// <summary>
        /// 已经发放优惠券的编号
        /// </summary>
        [XmlElement("coupon_number")]
        public long CouponNumber { get; set; }
    }
}
