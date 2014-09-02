using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// TmallPromotagTagRemovetagResponse.
    /// </summary>
    public class TmallPromotagTagRemovetagResponse : TopResponse
    {
        /// <summary>
        /// 删除操作是否成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
