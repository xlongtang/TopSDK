using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// SimpleFeed Data Structure.
    /// </summary>
    [Serializable]
    public class SimpleFeed : TopObject
    {
        /// <summary>
        /// feedId
        /// </summary>
        [XmlElement("id")]
        public long Id { get; set; }

        /// <summary>
        /// feed的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
