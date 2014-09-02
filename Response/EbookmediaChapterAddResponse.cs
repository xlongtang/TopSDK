using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// EbookmediaChapterAddResponse.
    /// </summary>
    public class EbookmediaChapterAddResponse : TopResponse
    {
        /// <summary>
        /// 电子书章节信息
        /// </summary>
        [XmlElement("ebook_chapter")]
        public EbookMediaChapter EbookChapter { get; set; }
    }
}
