using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionActivityDeleteResponse.
    /// </summary>
    public class PromotionActivityDeleteResponse : TopResponse
    {
        /// <summary>
        /// true成功，false失败
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
