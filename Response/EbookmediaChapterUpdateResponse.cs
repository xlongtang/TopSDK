using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// EbookmediaChapterUpdateResponse.
    /// </summary>
    public class EbookmediaChapterUpdateResponse : TopResponse
    {
        /// <summary>
        /// 是否修改成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
