using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionmiscActivityRangeRemoveResponse.
    /// </summary>
    public class PromotionmiscActivityRangeRemoveResponse : TopResponse
    {
        /// <summary>
        /// 去除活动参与的商品是否成功。
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
