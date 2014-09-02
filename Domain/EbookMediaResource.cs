using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// EbookMediaResource Data Structure.
    /// </summary>
    [Serializable]
    public class EbookMediaResource : TopObject
    {
        /// <summary>
        /// 文件资源状态（0:审核中 1：审核通过 2：审核不通过）
        /// </summary>
        [XmlElement("file_status")]
        public long FileStatus { get; set; }

        /// <summary>
        /// 文件资源后缀名
        /// </summary>
        [XmlElement("file_suffix")]
        public string FileSuffix { get; set; }

        /// <summary>
        /// 资源文件的类型（1：正文，0：试读）
        /// </summary>
        [XmlElement("file_type")]
        public long FileType { get; set; }

        /// <summary>
        /// 文件审核不通过原因
        /// </summary>
        [XmlElement("reason")]
        public string Reason { get; set; }
    }
}
