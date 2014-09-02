using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Top.Api.Domain
{
    /// <summary>
    /// Rankingforecast Data Structure.
    /// </summary>
    [Serializable]
    public class Rankingforecast : TopObject
    {
        /// <summary>
        /// 词ID
        /// </summary>
        [XmlElement("keyword_id")]
        public long KeywordId { get; set; }

        /// <summary>
        /// 主人昵称
        /// </summary>
        [XmlElement("nick")]
        public string Nick { get; set; }

        /// <summary>
        /// 返回prices对应的排名
        /// </summary>
        [XmlArray("prices")]
        [XmlArrayItem("number")]
        public List<long> Prices { get; set; }

        /// <summary>
        /// 词名称
        /// </summary>
        [XmlElement("word")]
        public string Word { get; set; }
    }
}
