using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionActivityAddResponse.
    /// </summary>
    public class PromotionActivityAddResponse : TopResponse
    {
        /// <summary>
        /// 活动信息，包括活动id和链接,目前只返回activity_id,activity_url
        /// </summary>
        [XmlElement("activity")]
        public Activity Activity { get; set; }
    }
}
