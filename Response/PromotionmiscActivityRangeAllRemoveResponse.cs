using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// PromotionmiscActivityRangeAllRemoveResponse.
    /// </summary>
    public class PromotionmiscActivityRangeAllRemoveResponse : TopResponse
    {
        /// <summary>
        /// 清空活动参与商品是否成功。
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
