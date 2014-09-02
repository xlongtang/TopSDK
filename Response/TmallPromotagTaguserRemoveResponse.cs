using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallPromotagTaguserRemoveResponse.
    /// </summary>
    public class TmallPromotagTaguserRemoveResponse : TopResponse
    {
        /// <summary>
        /// 打标结果是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
