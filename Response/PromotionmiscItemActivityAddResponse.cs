using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionmiscItemActivityAddResponse.
    /// </summary>
    public class PromotionmiscItemActivityAddResponse : TopResponse
    {
        /// <summary>
        /// 活动id。
        /// </summary>
        [XmlElement("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 是否保存成功。
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
