using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// EbookItemSendResponse.
    /// </summary>
    public class EbookItemSendResponse : TopResponse
    {
        /// <summary>
        /// 是否赠送成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
