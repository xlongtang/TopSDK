using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// VideoAddResponse.
    /// </summary>
    public class VideoAddResponse : TopResponse
    {
        /// <summary>
        /// 发布成功返回视频id
        /// </summary>
        [XmlElement("model")]
        public long Model { get; set; }
    }
}
