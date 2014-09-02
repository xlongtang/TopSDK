using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// EbookLib Data Structure.
    /// </summary>
    [Serializable]
    public class EbookLib : TopObject
    {
        /// <summary>
        /// 书库ID
        /// </summary>
        [XmlElement("ebook_lib_id")]
        public long EbookLibId { get; set; }

        /// <summary>
        /// 书库名称
        /// </summary>
        [XmlElement("ebook_lib_name")]
        public string EbookLibName { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }
    }
}
