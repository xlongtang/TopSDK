using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// EbookActivityItemInputResponse.
    /// </summary>
    public class EbookActivityItemInputResponse : TopResponse
    {
        /// <summary>
        /// 是否操作成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
