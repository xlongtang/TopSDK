using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// EbookmediaResourceAddResponse.
    /// </summary>
    public class EbookmediaResourceAddResponse : TopResponse
    {
        /// <summary>
        /// 是否修改成功
        /// </summary>
        [XmlElement("is_success")]
        public bool IsSuccess { get; set; }
    }
}
