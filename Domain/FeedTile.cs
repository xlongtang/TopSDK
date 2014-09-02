using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// FeedTile Data Structure.
    /// </summary>
    [Serializable]
    public class FeedTile : TopObject
    {
        /// <summary>
        /// type=pic或cover时，返回的图片地址
        /// </summary>
        [XmlElement("path")]
        public string Path { get; set; }

        /// <summary>
        /// type=cover或type=pic时有效，指图片高度
        /// </summary>
        [XmlElement("pic_height")]
        public long PicHeight { get; set; }

        /// <summary>
        /// type=cover或type=pic时有效，指图片宽度
        /// </summary>
        [XmlElement("pic_width")]
        public long PicWidth { get; set; }

        /// <summary>
        /// type=cover时有效，0时，feed的title不压封面 1时feed的title压封面
        /// </summary>
        [XmlElement("template")]
        public long Template { get; set; }

        /// <summary>
        /// type=text时，此内容有值
        /// </summary>
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// feed tile的类型，可以为：cover, pic, text, picItem
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
