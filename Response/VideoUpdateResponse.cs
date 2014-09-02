using System;
using System.Xml.Serialization;

namespace Top.Api.Response
{
    /// <summary>
    /// VideoUpdateResponse.
    /// </summary>
    public class VideoUpdateResponse : TopResponse
    {
        /// <summary>
        /// 更新视频成功返回true
        /// </summary>
        [XmlElement("model")]
        public bool Model { get; set; }
    }
}
