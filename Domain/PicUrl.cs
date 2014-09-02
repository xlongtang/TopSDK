using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// PicUrl Data Structure.
    /// </summary>
    [Serializable]
    public class PicUrl : TopObject
    {
        /// <summary>
        /// 图片链接地址
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
