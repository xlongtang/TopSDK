using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionActivityCancelResponse.
    /// </summary>
    public class PromotionActivityCancelResponse : TopResponse
    {
        /// <summary>
        /// true成功，false 失败
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
