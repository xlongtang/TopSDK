using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// AndroidVlowUrl Data Structure.
    /// </summary>
    [Serializable]
    public class AndroidVlowUrl : TopObject
    {
        /// <summary>
        /// android phone和pad播放的高清mp4文件。适用2.3版本的Android
        /// </summary>
        [XmlElement("hd")]
        public string Hd { get; set; }

        /// <summary>
        /// android phone和pad播放的流畅mp4文件。适用2.3版本的Android
        /// </summary>
        [XmlElement("ld")]
        public string Ld { get; set; }

        /// <summary>
        /// android phone和pad播放的标清mp4文件。适用2.3版本的Android
        /// </summary>
        [XmlElement("sd")]
        public string Sd { get; set; }

        /// <summary>
        /// android phone和pad播放的超清mp4文件。适用2.3版本的Android
        /// </summary>
        [XmlElement("ud")]
        public string Ud { get; set; }
    }
}
