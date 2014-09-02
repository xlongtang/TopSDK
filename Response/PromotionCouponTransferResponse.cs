using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionCouponTransferResponse.
    /// </summary>
    public class PromotionCouponTransferResponse : TopResponse
    {
        /// <summary>
        /// false代表失败，true代表成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
