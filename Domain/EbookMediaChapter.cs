using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// EbookMediaChapter Data Structure.
    /// </summary>
    [Serializable]
    public class EbookMediaChapter : TopObject
    {
        /// <summary>
        /// 章节创建时间
        /// </summary>
        [XmlElement("created")]
        public string Created { get; set; }

        /// <summary>
        /// 章节淘宝ID
        /// </summary>
        [XmlElement("tbid")]
        public long Tbid { get; set; }
    }
}
