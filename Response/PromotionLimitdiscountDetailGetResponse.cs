using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionLimitdiscountDetailGetResponse.
    /// </summary>
    public class PromotionLimitdiscountDetailGetResponse : TopResponse
    {
        /// <summary>
        /// 限时打折对应的商品详情列表。
        /// </summary>
        [XmlArray("item_discount_detail_list")]
        [XmlArrayItem("limit_discount_detail")]
        public List<LimitDiscountDetail> ItemDiscountDetailList { get; set; }
    }
}
