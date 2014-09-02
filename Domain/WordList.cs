using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// WordList Data Structure.
    /// </summary>
    [Serializable]
    public class WordList : TopObject
    {
        /// <summary>
        /// 关键词
        /// </summary>
        [XmlElement("word")]
        public string Word { get; set; }
    }
}
