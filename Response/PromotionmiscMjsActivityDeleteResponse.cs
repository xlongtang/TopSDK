using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionmiscMjsActivityDeleteResponse.
    /// </summary>
    public class PromotionmiscMjsActivityDeleteResponse : TopResponse
    {
        /// <summary>
        /// 是否成功删除活动。
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
