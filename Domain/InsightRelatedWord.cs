using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// InsightRelatedWord Data Structure.
    /// </summary>
    [Serializable]
    public class InsightRelatedWord : TopObject
    {
        /// <summary>
        /// 相关词
        /// </summary>
        [XmlElement("related_word")]
        public string RelatedWord { get; set; }

        /// <summary>
        /// 相关度
        /// </summary>
        [XmlElement("weight")]
        public string Weight { get; set; }
    }
}
