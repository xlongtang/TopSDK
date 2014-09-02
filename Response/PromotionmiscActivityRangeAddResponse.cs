using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionmiscActivityRangeAddResponse.
    /// </summary>
    public class PromotionmiscActivityRangeAddResponse : TopResponse
    {
        /// <summary>
        /// 增加商品范围是否成功。
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
