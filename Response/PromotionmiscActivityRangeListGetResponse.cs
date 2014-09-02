using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionmiscActivityRangeListGetResponse.
    /// </summary>
    public class PromotionmiscActivityRangeListGetResponse : TopResponse
    {
        /// <summary>
        /// 活动参与的商品列表
        /// </summary>
        [XmlArray("promotion_range_list")]
        [XmlArrayItem("promotion_range")]
        public List<PromotionRange> PromotionRangeList { get; set; }
    }
}
