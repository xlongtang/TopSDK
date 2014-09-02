using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionmiscItemActivityListGetResponse.
    /// </summary>
    public class PromotionmiscItemActivityListGetResponse : TopResponse
    {
        /// <summary>
        /// 只包含活动的主要信息，如activity_id，name，description，start_time，end_time，participate_range。优惠的其他详细信息，请通过taobao.promotionmisc.item.activity.get获取。
        /// </summary>
        [XmlArray("item_promotion_list")]
        [XmlArrayItem("item_promotion")]
        public List<ItemPromotion> ItemPromotionList { get; set; }

        /// <summary>
        /// 记录总条数。
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
