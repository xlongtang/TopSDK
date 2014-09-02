using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionmiscMjsActivityGetResponse.
    /// </summary>
    public class PromotionmiscMjsActivityGetResponse : TopResponse
    {
        /// <summary>
        /// 满就送活动信息。
        /// </summary>
        [XmlElement("mjs_promotion")]
        public MjsPromotion MjsPromotion { get; set; }
    }
}
