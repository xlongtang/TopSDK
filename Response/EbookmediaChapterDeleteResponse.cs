using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// EbookmediaChapterDeleteResponse.
    /// </summary>
    public class EbookmediaChapterDeleteResponse : TopResponse
    {
        /// <summary>
        /// 是否删除成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
