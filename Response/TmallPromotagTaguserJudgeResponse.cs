using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallPromotagTaguserJudgeResponse.
    /// </summary>
    public class TmallPromotagTaguserJudgeResponse : TopResponse
    {
        /// <summary>
        /// 用户是否有标签
        /// </summary>
        [XmlElement("has_tag")]
        public bool HasTag { get; set; }

        /// <summary>
        /// 服务调用是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
