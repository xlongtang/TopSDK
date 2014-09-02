using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallPromotagTagApplyResponse.
    /// </summary>
    public class TmallPromotagTagApplyResponse : TopResponse
    {
        /// <summary>
        /// 是否设置成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 优惠标签ID
        /// </summary>
        [XmlElement("tag_id")]
        public long TagId { get; set; }
    }
}
