using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// FuwuSaleLinkGenResponse.
    /// </summary>
    public class FuwuSaleLinkGenResponse : TopResponse
    {
        /// <summary>
        /// 通过营销链接接口生成的营销链接短地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
