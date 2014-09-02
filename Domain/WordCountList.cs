using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WordCountList Data Structure.
    /// </summary>
    [Serializable]
    public class WordCountList : TopObject
    {
        /// <summary>
        /// 关键词数量
        /// </summary>
        [XmlElement("count")]
        public long Count { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [XmlElement("word")]
        public string Word { get; set; }
    }
}
