using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// EbookYunpanTokenGetResponse.
    /// </summary>
    public class EbookYunpanTokenGetResponse : TopResponse
    {
        /// <summary>
        /// 访问云盘的token信息
        /// </summary>
        [XmlElement("ebook_yunpan_token")]
        public EbookYunpanToken EbookYunpanToken { get; set; }
    }
}
