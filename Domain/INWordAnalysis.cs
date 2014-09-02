using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// INWordAnalysis Data Structure.
    /// </summary>
    [Serializable]
    public class INWordAnalysis : TopObject
    {
        /// <summary>
        /// 词名称
        /// </summary>
        [XmlElement("word")]
        public string Word { get; set; }

        /// <summary>
        /// 词地域占比  格式：  地域名称:比例;地域名称2:比例2;
        /// </summary>
        [XmlElement("word_area_per")]
        public string WordAreaPer { get; set; }

        /// <summary>
        /// 词竞价分布  格式：  宝贝数:价格;宝贝数:价格;
        /// </summary>
        [XmlElement("word_hp_price")]
        public string WordHpPrice { get; set; }

        /// <summary>
        /// 词来源占比  格式：  来源名称1:比例值;来源名称2:比例值;
        /// </summary>
        [XmlElement("word_source_per")]
        public string WordSourcePer { get; set; }
    }
}
