using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// UmpPromotionGetResponse.
    /// </summary>
    public class UmpPromotionGetResponse : TopResponse
    {
        /// <summary>
        /// 优惠详细信息
        /// </summary>
        [XmlElement("promotions")]
        public PromotionDisplayTop Promotions { get; set; }
    }
}
