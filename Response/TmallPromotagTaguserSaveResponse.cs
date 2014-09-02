using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallPromotagTaguserSaveResponse.
    /// </summary>
    public class TmallPromotagTaguserSaveResponse : TopResponse
    {
        /// <summary>
        /// 打标结果是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
