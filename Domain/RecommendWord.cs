using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// RecommendWord Data Structure.
    /// </summary>
    [Serializable]
    public class RecommendWord : TopObject
    {
        /// <summary>
        /// 平均价格
        /// </summary>
        [XmlElement("average_price")]
        public string AveragePrice { get; set; }

        /// <summary>
        /// 相关度
        /// </summary>
        [XmlElement("pertinence")]
        public string Pertinence { get; set; }

        /// <summary>
        /// 搜索量
        /// </summary>
        [XmlElement("pv")]
        public string Pv { get; set; }

        /// <summary>
        /// 推荐的关键词
        /// </summary>
        [XmlElement("word")]
        public string Word { get; set; }
    }
}
