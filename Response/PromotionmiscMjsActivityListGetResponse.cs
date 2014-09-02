using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionmiscMjsActivityListGetResponse.
    /// </summary>
    public class PromotionmiscMjsActivityListGetResponse : TopResponse
    {
        /// <summary>
        /// 只包含活动的主要信息，如activity_id，aame，description，start_time，end_time，type，participate_range。优惠的其他详细信息，请通过taobao.promotionmisc.mjs.activity.get获取。
        /// </summary>
        [XmlArray("mjs_promotion_list")]
        [XmlArrayItem("mjs_promotion")]
        public List<MjsPromotion> MjsPromotionList { get; set; }

        /// <summary>
        /// 记录总条数。
        /// </summary>
        [XmlElement("total_count")]
        public long TotalCount { get; set; }
    }
}
