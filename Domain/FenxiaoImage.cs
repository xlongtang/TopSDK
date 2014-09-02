using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// FenxiaoImage Data Structure.
    /// </summary>
    [Serializable]
    public class FenxiaoImage : TopObject
    {
        /// <summary>
        /// 图片id
        /// </summary>
        [XmlElement("image_id")]
        public long ImageId { get; set; }

        /// <summary>
        /// 图片顺序
        /// </summary>
        [XmlElement("image_position")]
        public long ImagePosition { get; set; }

        /// <summary>
        /// 图片对应的url
        /// </summary>
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 当图片类型为属性图片时，表示图片对应的属性pv对。
        /// </summary>
        [XmlElement("properties")]
        public string Properties { get; set; }

        /// <summary>
        /// 图片类型（PRODUCT：产品图片  EXTPRODUCT：产品辅图  PROPERTIES：产品属性图片 ）
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
