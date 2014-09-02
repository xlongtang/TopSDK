using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// VideoPlayInfo Data Structure.
    /// </summary>
    [Serializable]
    public class VideoPlayInfo : TopObject
    {
        /// <summary>
        /// android  pad兼播放的m3u8列表文件（包含多码率）。适用大于等于3.0版本Android。
        /// </summary>
        [XmlElement("androidpad_url")]
        public string AndroidpadUrl { get; set; }

        /// <summary>
        /// android pad播放的mp4文件列表。适用2.3版本的Android
        /// </summary>
        [XmlElement("androidpad_v23_url")]
        public AndroidVlowUrl AndroidpadV23Url { get; set; }

        /// <summary>
        /// android  phone播放的m3u8列表文件（包含多码率，）。适用大于等于3.0版本Android。
        /// </summary>
        [XmlElement("androidphone_url")]
        public string AndroidphoneUrl { get; set; }

        /// <summary>
        /// android  phone播放的mp4文件列表。适用2.3版本的Android。
        /// </summary>
        [XmlElement("androidphone_v23_url")]
        public AndroidVlowUrl AndroidphoneV23Url { get; set; }

        /// <summary>
        /// Flash播放器地址，可直接通过PC浏览器播放
        /// </summary>
        [XmlElement("flash_url")]
        public string FlashUrl { get; set; }

        /// <summary>
        /// ipad播放的m3u8列表文件（包含多码率）
        /// </summary>
        [XmlElement("ipad_url")]
        public string IpadUrl { get; set; }

        /// <summary>
        /// iphone播放的m3u8列表文件（包含多码率）
        /// </summary>
        [XmlElement("iphone_url")]
        public string IphoneUrl { get; set; }

        /// <summary>
        /// Web嵌入html代码，可直接嵌入页面中，支持html5的video标签，支持HLS播放协议最终返回m3u8资源，否则返回mp4资源
        /// </summary>
        [XmlElement("web_url")]
        public string WebUrl { get; set; }
    }
}
