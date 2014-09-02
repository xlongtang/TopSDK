using System;
using System.Xml.Serialization;

namespace Top.Api.Domain
{
    /// <summary>
    /// INCategoryAnalysis Data Structure.
    /// </summary>
    [Serializable]
    public class INCategoryAnalysis : TopObject
    {
        /// <summary>
        /// 地域占比  格式：  地域名称:占比;地域名称:占比;
        /// </summary>
        [XmlElement("category_area_per")]
        public string CategoryAreaPer { get; set; }

        /// <summary>
        /// 竞价分布  格式：  宝贝数:价格;宝贝数:价格;
        /// </summary>
        [XmlElement("category_hp_price")]
        public string CategoryHpPrice { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [XmlElement("category_id")]
        public long CategoryId { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 来源占比  格式：  来源名称:比例;来源名称:比例;
        /// </summary>
        [XmlElement("category_source_per")]
        public string CategorySourcePer { get; set; }
    }
}
