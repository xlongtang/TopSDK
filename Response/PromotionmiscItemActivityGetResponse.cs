using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionmiscItemActivityGetResponse.
    /// </summary>
    public class PromotionmiscItemActivityGetResponse : TopResponse
    {
        /// <summary>
        /// 单品优惠活动信息。
        /// </summary>
        [XmlElement("item_promotion")]
        public ItemPromotion ItemPromotion { get; set; }
    }
}
