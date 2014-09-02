using System;
using System.Xml.Serialization;
using Top.Api.Domain;

namespace Top.Api.Response
{
    /// <summary>
    /// MediaFileAddResponse.
    /// </summary>
    public class MediaFileAddResponse : TopResponse
    {
        /// <summary>
        /// 上传到多媒体平台的文件
        /// </summary>
        [XmlElement("file")]
        public File File { get; set; }
    }
}
