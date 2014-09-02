using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// AlibabaLaiwangMediaUploadResponse.
    /// </summary>
    public class AlibabaLaiwangMediaUploadResponse : TopResponse
    {
        /// <summary>
        /// 多媒体文件上传后返回的文件标识.
        /// </summary>
        [XmlElement("mediaid")]
        public string Mediaid { get; set; }

        /// <summary>
        /// 访问上传文件的url路径信息.
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
