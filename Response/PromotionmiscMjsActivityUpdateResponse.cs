using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionmiscMjsActivityUpdateResponse.
    /// </summary>
    public class PromotionmiscMjsActivityUpdateResponse : TopResponse
    {
        /// <summary>
        /// 修改是否成功。
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
