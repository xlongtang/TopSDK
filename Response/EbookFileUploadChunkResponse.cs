using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// EbookFileUploadChunkResponse.
    /// </summary>
    public class EbookFileUploadChunkResponse : TopResponse
    {
        /// <summary>
        /// 文件ID
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
