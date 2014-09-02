using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionLimitdiscountGetResponse.
    /// </summary>
    public class PromotionLimitdiscountGetResponse : TopResponse
    {
        /// <summary>
        /// 限时打折列表。
        /// </summary>
        [XmlArray("limit_discount_list")]
        [XmlArrayItem("limit_discount")]
        public List<LimitDiscount> LimitDiscountList { get; set; }

        /// <summary>
        /// 满足该查询条件的限时打折总数量。
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
