using System;
using System.Xml.Serialization;
using Top.Api;

namespace Aliyun.Api.Domain
{
    /// <summary>
    /// VideoFeatures Data Structure.
    /// </summary>
    [Serializable]
    public class VideoFeatures : TopObject
    {
        /// <summary>
        /// 视频的码率
        /// </summary>
        [XmlElement("BitRate")]
        public long BitRate { get; set; }

        /// <summary>
        /// 视频时长(s)
        /// </summary>
        [XmlElement("Duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 视频的格式
        /// </summary>
        [XmlElement("FileFormat")]
        public string FileFormat { get; set; }

        /// <summary>
        /// 视频文件大小(byte)
        /// </summary>
        [XmlElement("FileSize")]
        public long FileSize { get; set; }

        /// <summary>
        /// 视频的帧率
        /// </summary>
        [XmlElement("FrameRate")]
        public long FrameRate { get; set; }

        /// <summary>
        /// 视频的高(像素)
        /// </summary>
        [XmlElement("Height")]
        public long Height { get; set; }

        /// <summary>
        /// 视频的宽(像素)
        /// </summary>
        [XmlElement("Width")]
        public long Width { get; set; }
    }
}
