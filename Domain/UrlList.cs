using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// UrlList Data Structure.
    /// </summary>
    [Serializable]
    public class UrlList : TopObject
    {
        /// <summary>
        /// url列表
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
