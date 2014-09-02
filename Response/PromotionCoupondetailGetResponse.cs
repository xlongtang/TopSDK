using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionCoupondetailGetResponse.
    /// </summary>
    public class PromotionCoupondetailGetResponse : TopResponse
    {
        /// <summary>
        /// 优惠券详细信息
        /// </summary>
        [XmlArray("coupon_details")]
        [XmlArrayItem("coupon_detail")]
        public List<CouponDetail> CouponDetails { get; set; }

        /// <summary>
        /// 是否还有下一页  true表示当前查询的结果还有下一页，false表示当前查询的结果已经是最后一页
        /// </summary>
        [XmlElement("is_have_next_page")]
        public bool IsHaveNextPage { get; set; }

        /// <summary>
        /// 查询数量总数
        /// </summary>
        [XmlElement("total_results")]
        public long TotalResults { get; set; }
    }
}
